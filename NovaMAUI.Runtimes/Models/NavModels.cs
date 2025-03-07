using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NovaMAUI.Runtimes.Models
{
    public class NavItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("jump")]
        public string Jump { get; set; }

        [JsonPropertyName("tooltip")]
        public string ToolTip { get; set; }

        [JsonPropertyName("items")]
        public NavItem[]? Items { get; set; }

        [JsonPropertyName("mobile")]
        public bool Mobile { get; set; }
    }
}
