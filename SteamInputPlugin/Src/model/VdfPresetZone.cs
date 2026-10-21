using System.Collections.Generic;

namespace com.github.lhervier.ksp.mod.steaminputextended.model
{
    public class VdfPresetZone
    {
        public EGamepadZone Zone { get; set; }
        public string GroupId { get; set; }
        public List<string> ModeshiftGroupIds { get; set; } = new List<string>();
    }
}