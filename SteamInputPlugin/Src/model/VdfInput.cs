using System.Collections.Generic;
using com.github.lhervier.ksp.mod.steaminput.ui.model;

namespace com.github.lhervier.ksp.mod.steaminput.model
{
    public class VdfInput
    {
        public EInput Name { get; set; }
        public List<VdfActivator> Activators { get; set; }
    }
}