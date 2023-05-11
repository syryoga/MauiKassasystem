using Microsoft.JSInterop;
using System.Threading.Tasks;

public static class Scripts {
    [JSInvokable]
    public static async Task PlayAudio() {
        await JSRuntime.Current.InvokeAsync < object > ("eval", "document.getElementById('audioPlayer').play();");
    }
}