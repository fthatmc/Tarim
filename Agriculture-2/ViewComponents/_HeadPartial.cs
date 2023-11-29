
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_2.ViewComponents
{
	public class _HeadPartial : ViewComponent //using Microsoft.AspNetCore.Mvc; eklendi
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
