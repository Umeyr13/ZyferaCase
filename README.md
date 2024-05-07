# Student Data API

Bu proje, öğrenci verilerini yönetmek için bir RESTful API sağlar. API, öğrenci bilgilerini alırken notlar arasında ortalamayı hesaplar ve veritabanında depolar. Bu API, okul konseyi tarafından kullanılmak üzere tasarlanmıştır.

## Başlarken

Bu talimatlar, uygulamanın yerel geliştirme ortamınızda nasıl çalıştırılacağını ve dağıtılacağını anlatacaktır.

### Gereksinimler

- .NET 6 SDK
- Visual Studio Code veya Visual Studio 2019 (isteğe bağlı)
- MSSQL Server

### Kurulum

1. Bu depoyu klonlayın:


2. `appsettings.json` dosyasında veritabanı bağlantı dizesini güncelleyin:

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=<server_adı>;Database=<veritabanı_adı>;Trusted_Connection=True;MultipleActiveResultSets=true"
}

 
3.
 Proje dizininde aşağıdaki komutu çalıştırarak veritabanını oluşturun:
dotnet ef database update

4.
Proje dizininde aşağıdaki komutu çalıştırarak uygulamayı başlatın:

dotnet run

Kullanım
API'ye POST isteği göndererek yeni öğrenci bilgileri ekleyebilirsiniz. Örneğin:

json
Copy code
POST /api/students
{
    "name": "Ali",
    "surname": "Yilmaz",
    "stdNumber": "B012X00012",
    "grades": [
        {
            "code": "MT101",
            "value": 90
        },
        {
            "code": "PH101",
            "value": 75
        },
        {
            "code": "CH101",
            "value": 60
        },
        {
            "code": "MT101",
            "value": 70
        },
        {
            "code": "HS101",
            "value": 65
        }
    ]
}
Bu istek, öğrenci bilgilerini eklerken her ders için notların ortalamasını hesaplar.

Katkıda Bulunma
Bu depoyu fork edin.
Yeni bir özellik dalı oluşturun (git checkout -b feature/NewFeature).
Yaptığınız değişiklikleri commit edin (git commit -m 'Add some feature').
Dalınıza push yapın (git push origin feature/NewFeature).
Bir pull isteği açın.

