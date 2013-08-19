using com.structureddocument.extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structureddocumentcom_sampleextension
{
    public class SampleExtension1 : ITemplateExtension
    {
        public string Name
        {
            get { return "SampleExtension1"; }
        }

        public string Description
        {
            get { return "SampleExtension1"; }
        }

        public string Author
        {
            get { return "NašeÚkoly.CZ s.r.o."; }
        }

        public string[] ButtonNames
        {
            get { return new string[] { "Sample 1", "Sample 2" }; }
        }

        public void OnClick(int buttonId, ITemplate template)
        {
            //
        }
    }
}
