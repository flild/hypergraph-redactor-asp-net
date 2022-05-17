using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace Blazor_DIp.design
{
    public class CustomModels : NodeModel
    {
        public CustomModels(Point? position = null) : base(position) { }

        public string Name10 { get; set; }

        // Here, you can put whatever you want, such as a method that does the addition
    }

}