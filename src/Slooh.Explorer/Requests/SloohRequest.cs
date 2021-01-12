using System.Linq;
using System.Net;

namespace Slooh.Explorer.Requests
{
    class SloohRequest
    {
        public virtual void FillFrom(SloohSite site)
        {
            var siteProperties = site.GetType().GetProperties().ToDictionary(p => p.Name);

            foreach (var property in GetType().GetProperties())
            {
                if (siteProperties.TryGetValue(property.Name, out var siteProperty))
                {
                    var value = siteProperty.GetValue(site);
                    property.SetValue(this, value);
                }
            }
        }
    }
}
