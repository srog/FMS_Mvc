using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.ViewComponents.CashFormat
{
    public class CashFormatViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int cashValue)
        {
            var cashString = (cashValue >= 1000000) 
                ? cashValue.ToString("£#,##0,,M", CultureInfo.InvariantCulture)
                : cashValue.ToString("£###,###", CultureInfo.InvariantCulture);
            if (cashValue == 0)
            {
                cashString = "£0";
            }
            return View("Default",cashString);
        }
    }
}
