#pragma checksum "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\RemoteApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf1cd20f10273527e878799c6b9011f24ab6629"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RemoteApi), @"mvc.1.0.view", @"/Views/Home/RemoteApi.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\_ViewImports.cshtml"
using MVCCodeTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\_ViewImports.cshtml"
using MVCCodeTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf1cd20f10273527e878799c6b9011f24ab6629", @"/Views/Home/RemoteApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b75fb8a8f232017bf91b50ff70a741563d7202bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RemoteApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\RemoteApi.cshtml"
  
    ViewData["Title"] = "Remote Api Test";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .titleSpan {
        background-color: lightgoldenrodyellow;
        color: red;
    }

    .randomUserClass {
        font-size: large;
        font-display: block;
        text-align: center;
    }

    .btnNextClass { 
        text-align: center;
    }

    .pageUserClass {
        font-size: large;
        font-display: block;
        text-align: center;
    }
</style>


<div class=""text-center"">
    <h3 class=""display-6"">
        <span class=""titleSpan""><u>Remote Api Test</u></span>
    </h3>
</div>

<p></p>
<div class=""row"">
    <div class=""col-sm-4""></div>
    <div class=""col-sm-4"">
        <div id=""randomUserData"" class=""randomUserClass""></div>
    </div>
    <div class=""col-sm-4""></div>
</div>

<p></p>
<div class=""row"">
    <div class=""col-sm-3""></div>
    <div class=""col-sm-6"">
        <div id=""randomUserDataTable"">
            <div>
                Gender : <span id=""genderSpan""></span>
            </div>
            <div>
              ");
            WriteLiteral("  Name : <span id=\"nameSpan\"></span>\r\n            </div>\r\n            <div>\r\n                Email : <span id=\"emailSpan\"></span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-sm-3\"></div>\r\n</div>\r\n\r\n");
#nullable restore
#line 63 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\RemoteApi.cshtml"
  
    var pageNumber = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<p></p>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-4\"></div>\r\n    <div class=\"col-sm-4 btnNextClass\">\r\n        <button id=\'btnNextData\' class=\'btn btn-success\'");
            BeginWriteAttribute("data", " data=\"", 1489, "\"", 1507, 1);
#nullable restore
#line 70 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\RemoteApi.cshtml"
WriteAttributeValue("", 1496, pageNumber, 1496, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            Next Data
        </button>
    </div>
    <div class=""col-sm-4""></div>
</div>
<p></p>
<div class=""row"">
    <div class=""col-sm-4""></div>
    <div class=""col-sm-4"">
        <div id=""pageUserData"" class=""pageUserClass""></div>
    </div>
    <div class=""col-sm-4""></div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            // when page loads first time
            var url = 'https://randomuser.me/api';
            $.get(url).done(function (data) {
                console.log(data.results[0]);

                if (data != null) {
                    var content = '';
                    var userImage = data.results[0].picture.medium;
                    console.log(userImage);
                    content += '<img src=' + userImage + ' style = ""width:50px;height:50px;"" />';
                    content += '&nbsp;&nbsp;&nbsp;<font color=""' + getColor(data.results[0].gender) + '"">' + data.results[0].name.title + ' ' + data.results[0].name.first + ', ' + data.results[0].name.last + '</font>';

                    $('#randomUserData').html(content);

                    $('#genderSpan').html(getGender(data.results[0]));
                    $('#nameSpan').html(getName(data.results[0]));
                    $('#emailSpan').htm");
                WriteLiteral(@"l(getEmail(data.results[0]));
                }
            });

            function getEmail(data) {
                return '<font color=""' + getColor(data.gender) + '"">' + data.email + '</font>';
            }

            function getName(data) {
                return '<font color=""' + getColor(data.gender) + '"">' + data.title + ' ' + data.first + ', ' + data.last + '</font>';
            }

            function getGender(data) {
                return '<font color=""' + getColor(data.gender) + '"">' + data.gender + '</font>';
            }
            function getColor(gender) {
                if (gender == 'male')
                    return 'blue';
                else return 'red';
            }


            function getPageData() {

                var currentPageNumber = $('#btnNextData').attr(""data"");

                var pageUrl = 'https://randomuser.me/api?page=' + currentPageNumber;
                $.get(pageUrl).done(function (data) {
                    console.log(");
                WriteLiteral(@"data.results[0]);

                    if (data != null) {
                        console.log(data);
                        var content = '';
                        var userImage = data.results[0].picture.medium;
                        console.log(userImage);
                        content += '<img src=' + userImage + ' style = ""width:50px;height:50px;"" />';
                        content += '&nbsp;&nbsp;&nbsp;<font color=""' + getColor(data.results[0].gender) + '"">' + data.results[0].name.title + ' ' + data.results[0].name.first + ', ' + data.results[0].name.last + '</font>';

                        $('#pageUserData').html(content);
                    }
                });
            }
            getPageData();


            $('#btnNextData').on('click', function () {
                var currentPageNumber = $(this).attr(""data"");
                currentPageNumber = parseInt(currentPageNumber) + 1;

                if (currentPageNumber >= 11)
                    return;

     ");
                WriteLiteral("           $(this).attr(\'data\', currentPageNumber);\r\n\r\n                console.log(currentPageNumber);\r\n                getPageData();\r\n            });\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591