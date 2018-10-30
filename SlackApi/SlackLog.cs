using Newtonsoft.Json;
using SlackApi.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SlackApi
{
    public class SlackLog
    {
        /// <summary>
        /// Post Slack Api With SlackModel
        /// </summary>
        /// <param name="slackModel"></param>
        private static void Log(SlackModel slackModel)
        {
            string SlackApiUrl = ConfigurationManager.AppSettings["SlackApiUrl"];

            if (!string.IsNullOrEmpty(SlackApiUrl))
            {
                SlackAttachmentsModel attachmentsModel = new SlackAttachmentsModel();
                attachmentsModel.attachments.Add(slackModel);

                StringContent queryString = new StringContent(JsonConvert.SerializeObject(attachmentsModel));

                HttpClient client = new HttpClient();
                client.PostAsync(SlackApiUrl, queryString);
            }
        }

        /// <summary>
        /// Slack Log Default
        /// </summary>
        /// <param name="TypeText"></param>
        /// <param name="ContentText"></param>
        /// <param name="ProjectName"></param>
        public static void Default(string TypeText, string ContentText, string ProjectName)
        {
            Log(new SlackModel { author_name = TypeText, text = ContentText, footer = string.Format("{0} | {1}", ProjectName, DateTime.Now.ToString()) });
        }

        /// <summary>
        /// Slack Log Success
        /// </summary>
        /// <param name="TypeText"></param>
        /// <param name="ContentText"></param>
        /// <param name="ProjectName"></param>
        public static void Success(string TypeText, string ContentText, string ProjectName)
        {
            Log(new SlackModel { color = "good", author_name = TypeText, text = ContentText, footer = string.Format("{0} | {1}", ProjectName, DateTime.Now.ToString()) });
        }

        /// <summary>
        /// Slack Log Warning
        /// </summary>
        /// <param name="TypeText"></param>
        /// <param name="ContentText"></param>
        /// <param name="ProjectName"></param>
        public static void Warning(string TypeText, string ContentText, string ProjectName)
        {
            Log(new SlackModel { color = "warning", author_name = TypeText, text = ContentText, footer = string.Format("{0} | {1}", ProjectName, DateTime.Now.ToString()) });
        }

        /// <summary>
        /// Slack Log Danger
        /// </summary>
        /// <param name="TypeText"></param>
        /// <param name="ContentText"></param>
        /// <param name="ProjectName"></param>
        public static void Danger(string TypeText, string ContentText, string ProjectName)
        {
            Log(new SlackModel { color = "danger", author_name = TypeText, text = ContentText, footer = string.Format("{0} | {1}", ProjectName, DateTime.Now.ToString()) });
        }

        /// <summary>
        /// Slack Log Info
        /// </summary>
        /// <param name="TypeText"></param>
        /// <param name="ContentText"></param>
        /// <param name="ProjectName"></param>
        public static void Info(string TypeText, string ContentText, string ProjectName)
        {
            Log(new SlackModel { color = "#439FE0", author_name = TypeText, text = ContentText, footer = string.Format("{0} | {1}", ProjectName, DateTime.Now.ToString()) });
        }
    }
}
