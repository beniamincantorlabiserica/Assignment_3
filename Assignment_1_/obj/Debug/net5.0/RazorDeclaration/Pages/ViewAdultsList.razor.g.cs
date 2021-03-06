// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment_1_.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Assignment_1_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Assignment_1_.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\ViewAdultsList.razor"
using Assignment_1_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\ViewAdultsList.razor"
using Assigment_1_.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAdultsList")]
    public partial class ViewAdultsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 135 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\ViewAdultsList.razor"
       
    private IList<Adult> adults;
    private IList<Adult> adultsToShow;

    protected override async Task OnInitializedAsync()
    {
        adults = await PeopleService.GetPeoples();
    }

    private void RemoveAdult(int id)
    {
        Adult ToRemove = adults.First(a => a.Id == id);
        adults.Remove(ToRemove);
        if (adultsToShow != null) adultsToShow.Remove(ToRemove);
       // FileContext.RemoveAdult(Id);
        PeopleService.DeleteAdult(id);
    }

    public void Filter(ChangeEventArgs changeEventArgs)
    {
        string? FilterByFirstName = null;
        try
        {
            FilterByFirstName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        if ((FilterByFirstName != null)&&(FilterByFirstName != ""))
        {
            adultsToShow = adults.Where(a => a.FirstName.Contains(FilterByFirstName)).ToList();
        }
        else
        {
            adultsToShow = null;
        }
    }
    
    private void Edit(int id) 
    {
        NavMgr.NavigateTo($"Edit/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleService PeopleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
    }
}
#pragma warning restore 1591
