using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SlackApi
{

    /// <summary>
    /// SlackLog Static Class
    /// </summary>
    public class SlackLog
    {

        /// <summary>
        /// Private Log Method
        /// </summary>
        /// <param name="slackModel"></param>
        private static void Log(SlackModel slackModel)
        {
            try
            {
                if (!string.IsNullOrEmpty(SlackConfig.ApiUrl))
                {
                    List<SlackModel> attachments = new List<SlackModel>();
                    attachments.Add(slackModel);

                    StringContent queryString = new StringContent(JsonConvert.SerializeObject(attachments));

                    using (HttpClient client = new HttpClient())
                    {
                        client.PostAsync(SlackConfig.ApiUrl, queryString);
                    }
                }
            }
            catch (Exception exp)
            {
                throw new Exception($"Slack Log Error Message : {exp.Message}");
            }
        }

        /// <summary>
        /// Slack Log For Default View
        /// </summary>
        /// <param name="TypeText"></param>
        /// <param name="ContentText"></param>
        /// <param name="ProjectName"></param>
        public static void Default(string TypeText, string ContentText, string ProjectName)
        {
            Log(new SlackModel { AuthorName = TypeText, Text = ContentText, Footer = string.Format("{0} | {1}", ProjectName, DateTime.Now.ToString()) });
        }
    }
}
