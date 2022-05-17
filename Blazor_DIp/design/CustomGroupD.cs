using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Models;

namespace Blazor_DIp.design
{
    public class CustomGroupD : GroupModel
    {
        public CustomGroupD(Diagram diagram, NodeModel[] children, byte padding = 30)
            : base(children, padding)
        {

        }

        public string Title { get; set; }
    }
}
