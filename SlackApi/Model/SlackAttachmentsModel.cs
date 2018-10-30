using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackApi.Model
{
    public class SlackAttachmentsModel
    {
        public List<SlackModel> attachments { get; set; }

        public SlackAttachmentsModel()
        {
            attachments = new List<SlackModel>();
        }
    }
}
