# 🛒 E-Ticaret Web API Projesi

Bu proje, modern yazılım mimarileri ve güçlü teknolojilerle geliştirilmiş bir **E-Ticaret Web API** uygulamasıdır. Genişletilebilir yapısı sayesinde microservice mimarisine kolaylıkla evrilebilir. Hem geliştiriciler hem de kurumsal ihtiyaçlara uygun güçlü bir temel sunar.

---

## 🚀 Teknolojiler & Altyapı

| Katman         | Teknoloji/Servis                                                                 |
|----------------|----------------------------------------------------------------------------------|
| Backend        | [.NET 9 Web API](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)         |
| Veri Tabanı    | PostgreSQL (Docker Container)                                                    |
| Mimarî         | Onion Architecture, CQRS, Mediator Pattern, Event Sourcing (temel düzeyde)       |
| Kimlik Doğrulama | Identity + JWT Authentication, OAuth2 (Google & Facebook Login)                |
| Dosya Yönetimi | Local Storage + Azure Blob Storage (Diğer Cloud servislerine hazır)              |
| Loglama        | Serilog + Seq ile görselleştirme                                                 |
| Gerçek Zamanlı İletişim | SignalR (Çoklu kullanımlara uygun) + Angular Custom SignalR Servisi     |
| E-Posta        | Mail Service (SMTP vb.)                                                          |
| Yetkilendirme  | Role-Based Access Control (RBAC), Claim Tabanlı Yetkilendirme                    |
| Diğer          | CORS Politikası, Fluent Validation, QRCode üretimi ve okuma                      |

---

## 🧱 Proje Mimarisi

Proje **Onion Architecture** temelinde yapılandırılmıştır. Katmanlar arası gevşek bağlılık ve bağımlılık tersine çevrimi prensipleri ile esnek bir yapı sağlanmıştır.

---

<pre lang="markdown"> 📦 <strong>ECommerceApi</strong> 
  ├── 📁 <strong>Application</strong> → CQRS, MediatR, DTO'lar, Validations 
  ├── 📁 <strong>Domain</strong> → Entity Sınıfları, Enumlar, Arayüzler 
  ├── 📁 <strong>Infrastructure</strong> → PostgreSQL, Serilog, Azure Blob, Mail, SignalR 
  ├── 📁 <strong>Persistence</strong> → Repository, UnitOfWork, Event Sourcing Bazlı Yapı 
  ├── 📁 <strong>WebApi</strong> → Controller'lar, Middlewares, JWT, CORS 
  └── 📁 <strong>Shared</strong> → Ortak Servisler, Response Modelleri, Constants </pre>

---

## 🔐 Kimlik Doğrulama & Yetkilendirme

- **JWT Bearer Token Authentication**
- **Google ve Facebook Login** desteği (OAuth2)
- **Rol Tabanlı Yetkilendirme (RBAC)**
- **Claim Tabanlı Yetkilendirme**

---

## 📦 Dosya & Depolama Yönetimi

- Uygulama içi dosya yüklemeleri hem **Local** hem de **Azure Blob Storage** üzerinde yönetilebilir.
- Yapı, gelecekte diğer cloud servisleri (AWS S3, Google Cloud Storage) ile entegre edilebilir.

---

## 🔄 CQRS & Mediator Pattern

- **Command / Query** ayrımı ile iş yükü yönetimi sağlandı.
- **MediatR** entegrasyonu ile loosely coupled bir yapı kuruldu.
- **Event Sourcing** temelleri `Repository` katmanında hazırlandı.

---

## 📡 SignalR Entegrasyonu

- **SignalR** çoklu hub destekleyen yapı ile entegre edildi.
- Angular tarafında özel **Custom SignalR Service** geliştirildi.
- Gerçek zamanlı bildirim, sipariş durumu güncellemesi, stok değişiklikleri gibi işlemler desteklenmektedir.

---

## 📩 Mail Servisi

- E-posta gönderimleri için özelleştirilebilir yapı.
- SMTP tabanlı veya dış servislerle çalışabilecek esneklik.

---

## 🧾 QR Code Özellikleri

- Ürünler için **QRCode** üretildi.
- **QRCode okutularak stok güncellemesi** yapılabilir hale getirildi.

---

## ✅ Diğer Özellikler

- **Fluent Validation** ile model doğrulama
- **CORS Politikaları** ile güvenli erişim kontrolü
- **Serilog** ile detaylı loglama
- **Seq** entegrasyonu ile log görselleştirmesi

---

## 🛠️ Kurulum (Docker + PostgreSQL)

- iletişime geçilirse yardımcı olunacak.

## NOT
- appsettings.json paylaşılmadı.
- Azure'da Client ve Api yayınlanmadı. Şuan localde çalışır vaziyette. Todo olarak eklendi.

