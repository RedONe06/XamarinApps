![Xamarin1](https://github.com/RedONe06/XamarinApps/assets/98191980/fe3273b6-a147-472b-b327-2267204222b6)
<img src="https://img.shields.io/static/v1?label=by&message=Alura&color=blue&style=for-the-badge"> <img src="https://img.shields.io/static/v1?label=Tech&message=.NET 2.0&color=darkblue&style=for-the-badge&logo=.NET"> <img src="https://img.shields.io/static/v1?label=Tech&message=C%23&color=darkblue&style=for-the-badge&logo=csharp"> <img src="https://img.shields.io/static/v1?label=Tech&message=Xamarin&color=darkblue&style=for-the-badge&logo=xamarin">
# Xamarin parte 1: Crie aplicativos mobile com Visual Studio 
## Descrição do sistema

O projeto se trata de um **aplicativo multiplataforma** construído a partir do Visual Studio. O sistema é um aplicativo de **Teste Drive** onde é possível escolher um carro a partir de uma listagem, definir características que alteram o preço final e agendar um horário para utilizar o carro alugado. Utilizou-se as ferramentas do [Xamarin](https://learn.microsoft.com/pt-br/xamarin/get-started/what-is-xamarin) para a construção do serviço e teve como base o curso _"Xamarin parte 1: crie aplicativos mobile com Visual Studio"_ disponível pela Alura.

## Sobre o curso

- Instalação de ambiente Xamarin para Visual Studio;
- Criação de páginas XAML em projeto com padrão MVVM (Model-View-ViewModel);
- Utilização de tags como StackLayout, Grid, ListView, Label, TableView, EntryCell, DatePicker e  TimePicker;
- Utilização de propriedades como OnPropertyChanged e alteração dinâmica de teclados para cada tipo de dados;
- Exibição de mensagens por DisplayAlert();
- Conceito de _Data Binding_ para tratamento no _code behind_;

  
![Xamarin2](https://github.com/RedONe06/XamarinApps/assets/98191980/ec706674-115e-4bc1-855f-5e30f5c511d2)
<img src="https://img.shields.io/static/v1?label=by&message=Alura&color=blue&style=for-the-badge"> <img src="https://img.shields.io/static/v1?label=Tech&message=.NET 2.0&color=pink&style=for-the-badge&logo=.NET"> <img src="https://img.shields.io/static/v1?label=Tech&message=C%23&color=pink&style=for-the-badge&logo=csharp"> <img src="https://img.shields.io/static/v1?label=Tech&message=Xamarin&color=pink&style=for-the-badge&logo=xamarin">

# Xamarin parte 2: Crie aplicativos mobile com Visual Studio
## Descrição do sistema

O projeto agora respeita o padrão **MVVM (Model View ViewModel)** e para isso utilizou-se de comandos e troca de mensagens entre classes. A listagem agora é realizada a partir de uma chamada para uma **API REST** que aguarda com um _ActivityIndicator_ e a aplicação só permite a confirmação dos agendamentos caso os campos sejam preenchidos corretamente.

## Sobre o curso

- Ajuste da arquitetura: desacoplamento do code behind em camadas intermediárias de ViewModel;
- Herança de classes para resgate de interfaces e métodos como OnPropertyChanged;
- Utilização de _MessagingCenter_ da mensageria do Xamarin Forms para evitar acoplamento;
- Utilização de ações realiazadas por _Command_ e não pelos eventos de _Clicked_;
- Conexão da lista de veículos a um servidor externo de Fipe através de um serviço HTTP GET;
- Utilização de novos conceitos como: _ContentPage.BindingContext_, _SelectedItem_, _OnAppearing_ e _OnDisappearing_, _Subscribe_ e _Unsubscribe_, _MessagingCenter_, _Command_ e _ICommand_, HTTP GET  e _StringAsync_, _DisplayAlert_ com 2 condições, _ChangeCanExecute()_, _ActivityIndicator_, etc.
