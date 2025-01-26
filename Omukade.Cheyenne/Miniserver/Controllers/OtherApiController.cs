using Microsoft.AspNetCore.Mvc;
using FlatBuffers;

namespace Omukade.Cheyenne.Miniserver.Controllers
{
    [Route("user/v1/external")]
    [ApiController]
    public class UserApiController : Controller
    {
        public UserApiController() { }
        [HttpPost]
        [Route("routing/route")]
        public async Task QueryRouteHandler()
        {
        }
        [HttpPost]
        [Route("data/get")]
        public async Task DataStoreGetHandler()
        {

        }
        [HttpPost]
        [Route("profile/getAll")]
        public async Task ProfileDataGetHandler()
        {

        }
    }
    [Route("user/v1/external/friend")]
    [ApiController]
    public class FriendApiController : Controller
    {
        public FriendApiController() { }
        [HttpPost]
        [Route("friendships/all")]
        public async Task FriendsGetAllHandler()
        {

        }
    }

}
