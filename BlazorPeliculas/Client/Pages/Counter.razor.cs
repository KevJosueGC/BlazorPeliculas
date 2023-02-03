using BlazorPeliculas.Client.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        //DECLARACIONI DE VARIABLES
        [Inject] ServiciosSingleton singleton { get; set; } = null!;
        [Inject] ServiciosTransient transient { get; set; } = null!;
        [Inject] IJSRuntime js { get; set; } = null!;

        [CascadingParameter] protected AppState appState { get; set; } = null!;

        IJSObjectReference? modulo;

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {

            modulo = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await modulo.InvokeVoidAsync("mostrarAlerta","hola mundo");

            currentCount++;
            currentCountStatic = currentCount;
            singleton.valor = currentCount;
            transient.valor = currentCount;
            await js.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        private async Task IncrementCountJavascript()
        {
            await js.InvokeVoidAsync("pruebaPuntoNetInstancia", DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
