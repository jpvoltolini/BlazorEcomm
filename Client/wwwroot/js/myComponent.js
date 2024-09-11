window.myComponentInterop = {
    initializeComponent: function () {
        // Inicializa o comportamento do jQuery aqui
        $(document).ready(function () {
            // Exemplo de uso do jQuery
            $('#myElement').fadeIn();
        });
    }
};

window.myComponentInterop = {
    setInputValue: function (value) {
        $('#inputElement').val(value); // Atualiza o valor do input no HTML
        // Notifica o Blazor da mudança, chamando o método C# com o valor atualizado
        DotNet.invokeMethodAsync('BlazorEcomm.Client', 'UpdateValueFromJS', value);
    }
};
