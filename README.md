# Proje Tasarım Belgesi

## Ball Run
### <font>17/05/2023</font>

## Proje Konsept

|| Kontrol edilen | Görünüm | Bu oyunda |
|-| ---------- | ------------ | ------------ |
|**1.Player Control**| <font color="red">Top toplayıcı:</font> Top | <font color="red">Üstten:</font> Görünen bir oyun sahnesidir  | <font color="red">Mouse:</font> Oyuncuyu sağa, sola ve yukarı hareket ettirebilir |



|| Oyun Sırasında | Ortaya çıkan nesneler | Oyunun amacı |
|-| ---------- | ------------ | ------------ |
|**2.Basic Gameplay**| Oyuncu, duvar engeller, çizgi engeller, coinler. | Ekranda var olacak sabitler | Oyuncu engellere çarpmadan coinleri toplayıp level bitirmesi |



|| Ses efektleri | Parça efektleri | [seçkinsel] Aynı Zamanda |
|-| ---------- | ------------ | ------------ |
|**3.Sound & Effects**| Player engellere çarptığında,coin toplarken, oyun başlarken, bir sonraki seviyeye geçerken | Coinler toplandığında | Seçkinsel herhangi bir efekt belirlenmedi |



|| Oyun ilerledikçe | Ve oyunda | [seçkinsel] Aynı Zamanda |
|-| ---------- | ------------ | ------------ |
|**4.Gameplay Mechanics**| Player ileri doğru hareket eder ve coinleri toplamaya çalışır aynı zamanda engellere çarpmamak için uğraş gösterir | Bir sonraki seviyeye geçmeyi zorlaştırır | Seçkinsel herhangi bir efekt belirlenmedi |



|| Can sistemi | Gameover | Tekrar sistemi |
|-| ---------- | ------------ | ------------ |
|**5.User Interface**| Can vardır | Player engellere çarpıp canı bittiğinde | Menü ekranı açılır ve sahneyi tekrar oynama imkanı sağlar |


|| Oyunun başında | Oyun uzunluğu | Ekstra |
|-| ---------- | ------------ | ------------ |
|**6.Other Features**| Oyuncu, engeller, coinler | 2 seviye olacak şekilde planlandı | Coinlerin  yerleri oyuncunun coinleri rahatça almasını zorlaştıracak ve oyuncuyu bitirmesi için hırslanıracak |



# Proje Zaman Çizelgesi

| Önemli Noktalar | Tanım | Tarih |
|---------------- | ----- | ----- |
|# 1 | -Tüm oynanabilirlik(Gameobject) için temel nesnelerle proje ve kamera kurulumlarının yapılması. | 23/04 |
|#2  | -Oyuncu tüm yönlerde hareket edebilir ve oyun alanından ayrılamaz. | 30/04 | 
|#3  | -Nesneler ekranın yukarısından ortaya çıkar(spawning) - Oyuncu başka bir hayvanla çarpıştığında zıplar - Oyuncu canlanma(life-up) ile çarpıştığında yok edilir.| 07/05 |
|#4  | -Temel nesneler ve arkaplan gerçek 3B Asset’lerle değiştirilir.| 14/05 |
|#5  | -Gameover mekanik programlandı, ancak kullanıcı arayüzüne eklenmedi - sadece konsolda görülüyor.| 18/05 |
|#6  | -Parçacık, ses efektleri ve arkaplan kaydırma(scrolling) eklendi.| 21/05 |
|#7  | -Parçacık, ses efektleri ve arkaplan kaydırma(scrolling) eklendi.| 25/05 |
|**Backlog**  | -Oyuncunun engellerin üzerinden atlamasını sağlayan Powerup nesnesi -Baş harflerinizi girmenizi ve puanları kaydetmenizi sağlayan Yüksek Puan panosu| 30/05 |


## Project Sketch

![Ball Run](https://www.jindoblu.com/wp-content/uploads/3_RunBallGame_Screenshot_1.png-1-960x665.jpg)






