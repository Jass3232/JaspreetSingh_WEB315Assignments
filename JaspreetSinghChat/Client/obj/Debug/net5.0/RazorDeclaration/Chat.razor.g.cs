// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace JaspreetSinghChat.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\_Imports.razor"
using JaspreetSinghChat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\_Imports.razor"
using JaspreetSinghChat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Cheema\Documents\GitHub\JaspreetSinghChat\Client\Chat.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string NameInput;
    private string messageInput;
     
     private string SendSomeoneTyping;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (Name, message) =>
        {
            var encodedMsg = $"{Name}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });
 hubConnection.On<string>("SendSomeoneTyping", (user) =>
        {
            if (string.IsNullOrEmpty(user)) SendSomeoneTyping = "is typing ..";
            else SendSomeoneTyping = $"{user} is typing..";
            SendSomeoneTyping = "";
            StateHasChanged();
        });
        await hubConnection.StartAsync();
    }

    async Task Send() =>
        await hubConnection.SendAsync("SendMessage", NameInput, messageInput);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
