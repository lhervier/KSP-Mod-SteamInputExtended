using System.Collections.Generic;
using com.github.lhervier.ksp.mod.steaminputextended.ui.model;

namespace com.github.lhervier.ksp.mod.steaminputextended.model
{
    public class VdfInput
    {
        public EInput Name { get; set; }
        public List<VdfActivator> Activators { get; set; }
    }
}