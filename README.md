
# 📅 MeetingApp

ASP.NET Core MVC kullanarak geliştirdiğim temel seviyeli bir toplantı yönetim uygulamasıdır. Bu proje, MVC mimarisi, Razor view engine, veri modeli oluşturma ve temel form işlemleri gibi konuların pekiştirilmesi amacıyla hazırlanmıştır.

---

## 🚀 Proje Özellikleri

- ASP.NET Core 8.0 ile geliştirilmiştir  
- MVC mimarisi uygulanmıştır  
- `Model`, `View`, `Controller` yapısı kullanılmıştır  
- Toplantı oluşturma ve listeleme işlemleri yapılmıştır  
- Razor syntax ile dinamik HTML sayfalar tasarlanmıştır  
- `Layout` yapısı ve `_ViewStart.cshtml` gibi temel mimari yapılandırmalar uygulanmıştır  
- Formlar ile kullanıcıdan veri alınmıştır (Model Binding)

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji              | Açıklama                        |
|------------------------|---------------------------------|
| ASP.NET Core 8.0       | Backend uygulama çatısı         |
| Razor Pages            | View oluşturma                  |
| C#                     | Programlama dili                |
| Visual Studio / VSCode | Geliştirme ortamı               |
| Git & GitHub           | Versiyon kontrol ve yedekleme   |

---

## 🖥️ Ekran Görüntüleri

> (İsteğe bağlı olarak proje içinden birkaç ekran görüntüsü ekleyebilirsin)

---

## 📂 Proje Yapısı (Örnek)

\`\`\`
MeetingApp/
├── Controllers/
    └── HomeController.cs
│   └── MeetingController.cs
├── Models/
│   └── MeetingInfo.cs
│   └── UserInfo.cs
│   └── Reposştory.cs
├── Views/
│   ├── Shared/
│   │   └── _Layout.cshtml
│   └── Meeting/
│       ├── Apply.cshtml
│       ├── Details.cshtml
│       ├── List.cshtml
│       ├── Thanks.cshtml
│   └── Home/
│       ├── Index.cshtml
├── wwwroot/
├── Program.cs
└── appsettings.json
\`\`\`

---

## 🔧 Kurulum ve Çalıştırma

1. Bu repoyu klonlayın:
   \`\`\`bash
   git clone https://github.com/yavuzsevimdev/MeetingApp.git
   \`\`\`

2. Projeyi Visual Studio / VSCode ile açın

3. Gerekli bağımlılıkları yükleyin (genelde otomatik olur)

4. Uygulamayı çalıştırmak için:
   \`\`\`bash
   dotnet run
   \`\`\`

---

## 📌 Notlar

Bu proje, Sadık Turan'ın ASP.NET Core 8.0 eğitimini takip ederek geliştirilmiştir. Eğitimde anlatılan konular birebir uygulanmıştır.

---

## 📫 İletişim

> GitHub üzerinden bana ulaşabilirsiniz: [yavuzsevimdev](https://github.com/yavuzsevimdev)
