**Bursa Uludağ Üniversitesi Kütüphane Otomasyonu**

Yapımı tamamlanmış olan kütüphane otomasyon sistemi Bursa Uludağ Üniversitesi İnegöl Yerleşkesi İşletme ve Meslek Yüksek Okulu için Arda Ünal ve Esra Kayhan tarafından hazırlanmıştır. 

**Yapım Amacı**

Kütüphane Görevlisi ve Öğrenci İşleri departmanları kullanımı için hazırlanmıştır. Kütüphane Görelisi için ; Kitap ekleme, güncelleme, silme işlemleri, öğrenci ekleme ve güncelleme işlemleri, emanet verme ve emanet alma işlemleri yapabilecek, bir çok verinin istatistiğine ulaşabilecek, iade edilmemiş kitapların listesini görebilecek. 

Öğrenci İşleri için; Öğrenci silme, öğrenci arama ve  emanet kaydı, silme işlemleri yapılabilecek. 

**Geliştirilebilecek Kısımlar** 

Öğrenciye bir kitap emanet edildikten sonra belirlenen süre geçtiği zaman ilk önce kütüphane görevlisine daha sonra ise kitabı iade etmemiş öğrenciye mail gönderilebilir.

Barkod ya da kare kod okuma sistemi ile kitap ekleme, güncelleme ve silme işlemi yapılabilir. 

BSSID kart okuma sistemi eklenerek öğrenci ekleme, güncelleme, çıkarma işlemleri için kullanılabilir. 

PDF şeklinde bulunan kitap verilerini tek tek eklemek yerine bütün olarak eklenebilir. 

Personel veya öğrenci kaydı oluşturulduğu zaman mail adreslerine onay maili gönderilebilir. 

Personel ve öğrenci numaraları doğru olduğunu doğrulayabilecek veri tabanı sistemi eklenebilir. 



**Uygulamanın Kullanım Kılavuzu**

Uygulamayı ilk olarak düzgün başlattığımızdan emin olmak için Uludağ Üniversitesi internet ağına bağlı olduğunuzdan emin olun. 

**Uludağ Üniversitesi İnternetine Bağlanma Yöntemleri**

1. Eduroam Wifi ağına bağlanmak
1. Uludağ Üniversitesi kampüs içerisinde LAN ile bağlanmak
1. SonicWall NetExtender VPN ile bağlanmak 


Uludağ Üniversitesi ağına bağlandıktan sonra uygulamayı çalıştırınız. İlk olarak **Giriş Yap** sayfası sizi karşılayacak. 


![Giriş Yap](https://github.com/ardaunall/Library-Project/blob/main/Ekran%20Görüntüleri/Giriş%20yap.png)

Kaydı olan kullanıcının sisteme girebilmesi için **Kullanıcı Adı** ve  **Şifre** alanları bulunmaktadır. Kullanıcıya kolaylık ve güvenlik sağlaması için **Beni Hatırla** ve **Şifreyi Göster** seçenekleri bulunmaktadır. Gerekli kullanıcı bilgileri girildikten sonra sisteme girmek için **Giriş Yap** butonu bulunmaktadır. Sisteme yeni giriş yapılacağı için **Kayıt Ol** butonu ile personel için kayıt ol sayfasını giriş yapınız. 


**Kütüphane Görevlisi İçin Kullanımı**

![Personel Kayıt](https://github.com/ardaunall/Library-Project/blob/main/Ekran%20Görüntüleri/Personel%20Kayıt.png)

Personele ait bilgileri giriniz ve **Kaydet** butonu ile kayıt işlemini gerçekleştiriniz. Kayıt işlemi başarı ile tamamlandıktan sonra **Geri Dön** butonu yardımıyla giriş yap sayfasına dönün. Kullanıcı bilgilerinizi girin ve giriş yap butonu ile ana sayfaya girin. 

![Ana Sayfa](https://github.com/ardaunall/Library-Project/blob/main/Ekran%20Görüntüleri/Ana%20Sayfa.png)

Ana sayfada öğrenci, kitaplar, emanetler, iade edilmeyi bekleyen kitaplar, kütüphane istatistikleri ve çıkış yap butonları karşılamaktadır. Karşınıza çıkan tablo kitapların bilgilerinin bulunduğu kitap listesidir. Tablonun üstünde kitap adına göre, yazara göre kategoriye göre ve yayın evine göre arama yapabilmeniz için alanlar bulunmaktadır. Bu alanlara aramak istediğiniz değeri girdiğiniz de eş zamanlı olarak listelenecektir. 


Öğrenci ile ilgili işlemleri yapabilmek için **Öğrenciler** yazısına tıklayın. 


![Öğrenci İşlemleri](https://github.com/ardaunall/Library-Project/blob/main/Ekran%20Görüntüleri/Öğrenci%20İşlemleri.png)


Öğrenciler sayfasına geldiğinizde öğrencilerin bilgilerini girebileceğiniz öğrenci numarası, isim, soy isim, bölüm ve e-mail alanları bulunmaktadır. Bu alanları öğrencinin bilgileri ile doldurduktan sonra sağ tarafta görünen tabloya eş zamanlı olarak listelenecektir. Herhangi bir öğrenciyi kontrol etmek ya da bilgilerini güncellemek için öğrenci numarasını yazar arayabilirsiniz. Bilgileri güncellenmek istenen öğrenciyi tablodan seçtikten sonra istenilen bilgileri güncelleyin ve **Güncelle** butonuna basın. Gerekli işlemler tamamlandıktan sonra **Geri Dön** butonun yardımıyla ana sayfaya dönün. 


Kitap işlemleri için **Kitaplar** yazısına tıklayın. 

![Kitap İşlemleri](https://github.com/ardaunall/Library-Project/blob/main/Ekran%20Görüntüleri/Kitap%20İşlemleri.png)


Sol tarafta kitap bilgilerini ekleyeceğiniz alanlar karşılamaktadır. Sağ tarafta kitap bilgilerinin bulunduğu tablo bulunmaktadır. Kitap eklendiğinde, güncellendiğinde veya çıkartıldığında eş zamanlı olarak tabloda listelenecektir. Kitap adına göre arama yapılabilmesi için tablonun üstünde bulunan alana kitabın adını yazarak arayabilirsiniz. Tablonun altında bulunan **Kitap Güncelle** ve **Kitap Çıkar** butonları bulunmaktadır. Bu işlemleri yapmak için tablodan işlemin yapılacağı kitap seçilmelidir. Kitap işlemleri tamamlandıktan sonra **Geri Dön** butonu yardımıyla ana sayfaya dönün. 

**NOT:** Emanet kaydı bulunan kitap silinemez. 

Emanet işlemleri için **Emanetler** yazısına tıklayın. 

![Emanet İşlemleri](https://github.com/ardaunall/Library-Project/blob/main/Ekran%20Görüntüleri/Emanet%20İşlemleri.png)

Emanet sayfasında emanet bilgilerini doldurmak için alanlar bulunmaktadır. Öğrenci numarası alanın ister seçebilir ister yazabilirsiniz. Kitap adının ister seçebilir ister yazabilirsiniz. Öğrenci numarası ve kitap adı bilgileri girildikten sonra **Emanet Tarihi** ve **Teslim Tarihini** takvim resmine basarak seçebilirsiniz. Bütün bilgiler girildikten sonra **Emanet Ver** butonuna tıklayarak emanet işlemini tamamlayabilirsiniz. 

Öğrenci kitabı teslim etmek için getirdiğinde aşağıdaki tablodan seçim yapıp **Kitabı İade Al** butonuna tıklayarak kitabı iade alın. Bu sayede emanet kaydı oluşacaktır ve silinmeyecektir. Emanet kaydı bulunan kitabı silmek için tablodan kitabı seçin ve **Emanet kaydını Sil** butonuna tıklayarak emanet kaydını silin. Daha sonra **Kitap** sayfasına dönerek kitabı silebilirsiniz. **Geri Dön** butonu yardımıyla ana sayfaya dönün. 


Emanet edilmeyenleri görmek için **İade Listesi** yazısına tıklayın. 

![İade Edilecekler Listesi](https://github.com/ardaunall/Library-Project/blob/main/Ekran%20Görüntüleri/İade%20Edilecekler%20Listesi.png)

Karşınıza çıkan tabloda kitap iadesini henüz gerçekleştirmemiş öğrenci bilgileri, kitap adı ve teslim tarihi bulunmaktadır. Tablonun üstünde bulunan alanda öğrenci numarasına göre arama yapabilirsiniz. **Geri Dön** butonu yardımıyla ana sayfaya dönün. 

Kütüphane istatistikleri için **İstatistik** yazısına tıklayın. 


![İstatistik](https://github.com/ardaunall/Library-Project/blob/main/Ekran%20Görüntüleri/İstatistik.png)


İstatistik sayfasında en çok okunan kitap, en çok okunan yazar, en çok tercih edilen kategori ve en çok kitap okuyan bilgileri bulunmaktadır. Sayfanın altında ise anlık olarak toplam öğrenci sayısı, toplam kitap sayısı, toplam yazar ve toplam kategori bulunmaktadır. **Geri Dön** butonu yardımıyla ana sayfaya dönün. 

Hesaptan çıkış yapmak için **Çıkış** yazısına tıklayabilirsiniz. 


**Öğrenci İşleri İçin Kullanımı**

Öğrenci işleri kullanıcı kaydın oluşturduktan sonra giriş yap sayfasında gerekli olan üye bilgilerini girin ve **Giriş Yap** butonuna tıklayın. 



![Öğrenci İşleri](https://github.com/ardaunall/Library-Project/blob/main/Ekran%20Görüntüleri/Öğrenci%20İşleri.png)



Soldaki tabloda öğrencilerin emanet kaydı bulunmaktadır. Sağdaki tabloda ise öğrencilerin bilgileri bulunmaktadır. Öğrenci emanet bilgileri kontrol edildikten sonra eğer **teslim edilmeyen** kitabı yok ise ilk olarak emanet kaydını soldaki tablodan seçip **Emaneti Sil** butonuna basın. Emanet kaydını sildikten sonra öğrenciyi silmek için sağdaki tablodan öğrenciyi seçip **Öğrenci Sil** butonuna basın. **Geri Dön** butonu yardımıyla giriş yap sayfasına dönün.

**NOT:** Emanet kaydı bulunan öğrenci silinemez. 

