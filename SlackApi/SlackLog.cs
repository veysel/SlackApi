using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SlackApi
{

    /// <summary>
    /// SlackLog Static Class
    /// </summary>
    public class SlackLog
    {

        /// <summary>
        /// Private Log Method.
        /// </summary>
        /// <param name="slackModel"></param>
        /// <returns>HttpResponseMessage</returns>
        private static HttpResponseMessage Log(SlackModel slackModel)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    slackModel.Footer = $"{slackModel.Footer} | {DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}";

                    object model = new { attachments = new List<SlackModel> { slackModel } };

                    var stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

                    var response = client.PostAsync(SlackConfig.ApiUrl, stringContent).Result;

                    return response;
                }
            }
            catch (Exception exp)
            {
                throw new Exception($"Slack Log Error Message : {exp.Message}");
            }
        }

        /// <summary>
        /// Slack Log Default Method.
        /// </summary>
        /// <param name="ContentText"></param>
        /// <param name="Title"></param>
        /// <param name="ProjectName"></param>
        /// <returns>HttpResponseMessage</returns>
        public static HttpResponseMessage Default(string ContentText, string Title = "Default", string ProjectName = "Slack Api")
        {
            return Log(new SlackModel { Text = ContentText, Title = Title, Footer = ProjectName });
        }

        /// <summary>
        /// Slack Log Success Method.
        /// </summary>
        /// <param name="ContentText"></param>
        /// <param name="Title"></param>
        /// <param name="ProjectName"></param>
        /// <returns>HttpResponseMessage</returns>
        public static HttpResponseMessage Success(string ContentText, string Title = "Success", string ProjectName = "Slack Api")
        {
            return Log(new SlackModel { Color = "good", Text = ContentText, Title = Title, Footer = ProjectName });
        }

        /// <summary>
        /// Slack Log Warning Method.
        /// </summary>
        /// <param name="ContentText"></param>
        /// <param name="Title"></param>
        /// <param name="ProjectName"></param>
        /// <returns>HttpResponseMessage</returns>
        public static HttpResponseMessage Warning(string ContentText, string Title = "Warning", string ProjectName = "Slack Api")
        {
            return Log(new SlackModel { Color = "warning", Text = ContentText, Title = Title, Footer = ProjectName });
        }

        /// <summary>
        /// Slack Log Danger Method.
        /// </summary>
        /// <param name="ContentText"></param>
        /// <param name="Title"></param>
        /// <param name="ProjectName"></param>
        /// <returns>HttpResponseMessage</returns>
        public static HttpResponseMessage Danger(string ContentText, string Title = "Danger", string ProjectName = "Slack Api")
        {
            return Log(new SlackModel { Color = "danger", Text = ContentText, Title = Title, Footer = ProjectName });
        }

        /// <summary>
        /// Slack Log Info Method.
        /// </summary>
        /// <param name="ContentText"></param>
        /// <param name="Title"></param>
        /// <param name="ProjectName"></param>
        /// <returns>HttpResponseMessage</returns>
        public static HttpResponseMessage Info(string ContentText, string Title = "Info", string ProjectName = "Slack Api")
        {
            return Log(new SlackModel { Color = "#439FE0", Text = ContentText, Title = Title, Footer = ProjectName });
        }
    }
}
