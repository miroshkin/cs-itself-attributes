using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CS.Iself.Attributes
{
    public class HelpAttribute : Attribute
    {
        private string url;
        private string topic;

        public HelpAttribute(string url)
        {
            this.url = url;
        }

        public string Topic { get; set; }
        public string Url { get; set; }

    }
}
