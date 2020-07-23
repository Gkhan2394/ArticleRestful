# Projede kullanıdığınız tasarım desenleri hangileridir? Bu desenleri neden kullandınız?
1. *Disposable Pattern*:
    Değerli, maliyetli,önemli  nesneleri kullandıktan sonra silme işlemini garbage collector a bırakmadan hemen silmek için kullanılır.Ben de bu yüzden TContext nesnesinde bu    pattern i kullandım. 
2. *Repository Pattern*:
    Tek bir entity için 5 tane metodumuz olduğunu düşünürsek 20 tane entity için 100 adet metod yazmamız gerekecektir.Daha büyük projelerde entity sayısı arttıkça yazılacak metod sayısı çok artacaktır ve bunların yazımı ve yönetimi zorlaşacaktır.Generic bir IRepository sayesinde bu metodlar sadece bir kere yazılacaktır. 
3.  *Dependency Injection (DI)*:
     Bir nesne kullanılırken başka nesnelere ihtiyac duyabilir.Fakat bu şekilde kullandığı nesneye iletişimde olduğu nesneye bağımlılığı artar.nesnelerde değişiklik söz konusu olduğunda işler karışabiliyor.Bu yüzden nesnelerin birbirine bağımlılığı Dependecy injection ile azaltılmalı.İnterace sayesinde nesnelerin birbirine bağımlılığını azaltarak koddaki değişiklik veya geliştirmeler gerektiğinde zorlanmadan kodlara müdahele edebileceğim ve kolaylıkla yenilik ekleyebileceğim.
4.  *N layer architecture,DAL,BLL,UIL,Database*:
    Proje katmanlı mimari sayesinde daha kolay yönetilebilir.Veri tabanından veri çekme, veri gönerme işlemleri bir katmanda yapılmakta.Veri iletişimini saplayacak servisler bir katmanda.Bu şekilde bu katmanların birbirinden ayrılması sayesinde bi hata olduğunda daha rahat müdahele edilebilecek.Geliştirme, bakım yapma, değiştirme işleri daha rahat yapılabilecek çünkü herşey iç içe girmiş durumda değil herşey ayrı katmanda her katmanın görevi ayrı.
5.  *Restful*:
    REST, client-server arasındaki haberleşmeyi sağlayan HTTP protokolü üzerinden çalışan bir mimaridir. REST ,servis yönelimli mimari üzerine oluşturulan yazılımlarda kullanılan bir transfer yöntemidir.İstemci ve sunucu arasında XML ve JSON verilerini taşıyarak uygulamanın haberleşmesini sağlar.REST mimarisini kullanan servislere ise RESTful servis denir.


# Kullandığınız teknoloji ve kütüphaneler hakkında daha önce tecrübeniz oldu mu? Tek tek yazabilir misiniz?
Asp .Net aktif olarak kullanıyor bulunmaktayım.Gerek işte olsun gerek kendimi geliştirme adına aldığım eğitim videolarında, araştırmalarımda olsun sürekli kullanmış bulunmaktayım.Entity Framework teknolojisini kullanıyorum.Sql i sürekli kullanıyorum.MsSQL i kullanıyorum aktif olarak..Net Core hakkında kendimi geliştirmekteyim.Videolar izleyerek araştırmalar yaparak küçük küçük alıştırmalarda kullanmaktayım.Wep Api teknolojisinde de kendimi geliştirmekteyim.Videolar izleyerek ve araştırarak, küçük alıştırmalarla kendimi geliştirmekteyim.Autofac kullanarak gerçeklemeleri startup dosyasında değilde ayrı bir dosyada yaparak eğer ki örneğin proje mvc ye çevrilmek istense dahi sadece bu autofac i projeye tanıtarak aktif olarak kullanabilmekteyim.Bu projeyi solid kurallarına dikkat ederek ve bazı design patternleri kullanarak gayet generic ve loosely coupled a uygun bir şekilde yaptım.Sınıfların birbirine bağaımlılığı olabildiğince az.Proje geliştirilmeye açık bir durumdadır.Mümkün olduğunca kolay gelişebilecek şekilde tasarladım projeyi.


# Daha geniş vaktiniz olsaydı projeye neler eklemek isterdiniz?
Şuan proje gayet generic ve gevşek bağlılık kullanılarak yapıldığı için geliştirmeye çok açık.Tek entity bulunmakta şuan.Fakat bundan sonra istenildiği kadar entity eklenebilir örneğin yazar eklenebilir.Makalelerin kategorileri olabilir.Makalelere yorum ekleme sistemi yapılabilir.İstenildiği kadar entity eklensin crud işlemleri generic bir sınıfta yapıldığı için tekrar tekrar yapılmayacak.Projeye rol yönetimi eklenebilir.Bu sayede üyelik ve adminlik sağlanabilir.Bu sayede gerekli kişiler makale ekleyebilir, silebilir ve düzeltebilir.İzni olmayan kişiler müdahele edemez.Dahat detaylı bir hata yönetimi sistemi yapılabilir.
