using System.Collections.Generic;
using com.github.lhervier.ksp.mod.steaminputextended.model;

namespace com.github.lhervier.ksp.mod.steaminputextended.ui.model
{
    public class UIPhysicalZone
    {
        public EGamepadZone Zone { get; set; }
        public string Label { get; set; }
        public List<UISection> Sections { get; set; } = new List<UISection>();
    }
}
