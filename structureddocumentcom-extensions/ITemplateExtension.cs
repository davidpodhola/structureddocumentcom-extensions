using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.structureddocument.extensions
{
    public interface ITemplateExtension
    {
        string Name { get; }
        string Description { get; }
        string Author { get; }

        string[] ButtonNames { get; }

        void OnClick(int buttonId, IDocument template);           
    }
}
