namespace TwitterFeed.Controllers
{
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Models;

    public class TwitterController : Controller
    {
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync()
        {
            var items = await DocumentDBRepository<TwitterFeed>.GetItemsAsync(d => d.SentimentScore > 0);
            return View(items);
        }
    }
}