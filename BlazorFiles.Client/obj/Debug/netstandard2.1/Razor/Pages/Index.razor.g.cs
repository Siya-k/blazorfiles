#pragma checksum "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab58ee00b911bff18a2e39be9c453496741266cf"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFiles.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\_Imports.razor"
using BlazorFiles.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\_Imports.razor"
using BlazorFiles.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Upload file!</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "file");
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
                                                                async () => await OpenFileAsync()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(13, (__value) => {
#nullable restore
#line 14 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
                                     inputReference = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "ul");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "li");
            __builder.AddContent(18, "File Name: ");
            __builder.AddContent(19, 
#nullable restore
#line 16 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
                                fileName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "li");
            __builder.AddContent(22, "Size: ");
            __builder.AddContent(23, 
#nullable restore
#line 17 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
                           size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "li");
            __builder.AddContent(26, "Type: ");
            __builder.AddContent(27, 
#nullable restore
#line 18 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
                           type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-block btn-success");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
                                                            async () => await UploadFileAsync()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Upload File");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n");
#nullable restore
#line 23 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
         if (!string.IsNullOrWhiteSpace(message))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "            ");
            __builder.AddMarkupContent(37, "<div class=\"alert alert-success\">\r\n                File has been uploaded\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-4");
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 31 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
         if (imagePath != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "            ");
            __builder.OpenElement(44, "img");
            __builder.AddAttribute(45, "style", "width:150px");
            __builder.AddAttribute(46, "src", 
#nullable restore
#line 33 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
                                           imagePath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 34 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\dell\source\repos\BlazorFiles\BlazorFiles.Client\Pages\Index.razor"
 
    ElementReference inputReference;
    string message = string.Empty;
    string imagePath = null;

    string fileName = string.Empty;
    string type = string.Empty;
    string size = string.Empty;

    Stream fileStream = null;

    async Task OpenFileAsync()
    {
        // Read the files
        var file = (await fileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

        if (file == null)
            return;

        // Get the info of that files 
        var fileInfo = await file.ReadFileInfoAsync();
        fileName = fileInfo.Name;
        size = $"{fileInfo.Size}b";
        type = fileInfo.Type;

        using (var ms = await file.CreateMemoryStreamAsync((int)fileInfo.Size))
        {
            fileStream = new MemoryStream(ms.ToArray());
        }
    }

    async Task UploadFileAsync()
    {

        // Create the content 
        var content = new MultipartFormDataContent();
        content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");

        content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName);

        string url = "https://localhost:44345";

        var response = await client.PostAsync($"{url}/api/images", content);

        if(response.IsSuccessStatusCode)
        {
            var uploadedFileName = await response.Content.ReadAsStringAsync();
            imagePath = $"{url}/{uploadedFileName}";
            message = "File has been uploaded successfully!";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReader { get; set; }
    }
}
#pragma warning restore 1591
