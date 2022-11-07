using Greener.Models;
using Microsoft.AspNetCore.Components;

namespace Greener.Pages
{
	public partial class PlantListModel : ComponentBase
	{
		[Inject]
		public HttpClient Http { get; set; }
		protected List<Plant> plants = new List<Plant>();
		protected Plant plant = new Plant();
		protected override async Task OnInitializedAsync ( )
		{
			await GetPlantList();
		}
		protected async Task GetPlantList ( )
		{
			plants = await Http.GetFromJsonAsync<List<Plant>>("api/<PlantController>");
		}

	}
}
