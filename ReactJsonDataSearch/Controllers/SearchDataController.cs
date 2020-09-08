using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ReactJsonDataSearch.Controllers
{
    [Route("api/[controller]")]
    public class SearchDataController : Controller
    {
        private IHostingEnvironment _env;
        public SearchDataController(IHostingEnvironment env)
        { 
            _env = env;
        }
        

        [HttpGet("[action]")]
        [Produces("text/html")]
        public ActionResult<string> GetJsonData()
        {
            var webRoot = _env.WebRootPath;
            var fileContent = System.IO.File.ReadAllText(webRoot + "/SearchValue.html");
            return base.Content(fileContent, "text/html");

        }

        // we can use different React script logic like :
//        var Demo = React.createClass({

//  getInitialState: function() {
//    return {showExternalHTML: false};
//},
  
//  render: function()
//{
//    return (
//      < div >
//        < button onClick ={ this.toggleExternalHTML}> Toggle Html </ button >
//        {
//        this.state.showExternalHTML ? < div >

//         < div dangerouslySetInnerHTML ={ this.createMarkup()} ></ div >
  
//          </ div > : null}
//      </ div >
//    );
//},
  
//  toggleExternalHTML: function()
//{
//    this.setState({ showExternalHTML: !this.state.showExternalHTML});
//},
  
//  createMarkup: function()
//{
//    return { __html: '<div class="ext">Hello!</div>'};
//}

//});

//ReactDOM.render(
//  <Demo />,
//  document.getElementById('container')
//);
//);

//        .ext {
//  margin-top: 20px;
//  width: 100%;
//  height: 100px;
//  background: green;
//  color: white;
//  font-size: 40px;
//  text-align: center;
//  line-height: 100px;
//}
//<script src = "https://cdnjs.cloudflare.com/ajax/libs/react/15.1.0/react.min.js" ></ script >
//< script src="https://cdnjs.cloudflare.com/ajax/libs/react/15.1.0/react-dom.min.js"></script>
//<div id = "container" ></ div >


}
}
