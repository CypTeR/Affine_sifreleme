# Affine_sifreleme
11 haneli sayıları şifreleme ve şifre çözme
Amaç
Günümüzde teknolojideki hızlı ilerleme kodların, şifrelerin ve gizli mesajların matematiksel bilimi olan  kriptolojiye duyulan ihtiyacı daha da artırmıştır. Bankacılık, web sitesi üyelikleri, teknolojik alet parolaları, online işlemler gibi hayatımızın hemen hemen her alanında bir şifre belirlemek zorunda kalmakta, bu şifreleri güvenli bir şekilde saklamakta, ya da hatırlamakta zorluklar yaşamaktayız. Bu amaçla pek çok şifreleme tekniği ortaya çıkmıştır ancak bu tekniklerin bir çoğunda temel problem şifrelenen verinin orijinal haline geri çevrilmesi yani çözümlenmesi aşamasındadır.
Bu projede rakamlar arası ilişkiler araştırılmış, özellikle 3 ve 7 rakamlarının çeşitli fonksiyonlarının mod10 daki değerleri arasında ilginç ilişkiler görülmüş ve bulunan fonksiyonlar arasındaki ilişkiler kullanılarak yeni bir şifreleme ve çözümleme algoritması oluşturmak amaçlanmıştır. 

Yöntem
Bu projede 3 ve 7 rakamlarının  katlarının mod 10 daki değerlerinin farklı rakamlara karşılık gediği  fark edilmiş ve bu özellikleri şifrelemede kullanılmıştır. 
![image](https://user-images.githubusercontent.com/29151932/115942470-1dbda080-a4b3-11eb-8a09-859a7d37a8c6.png)



![image](https://user-images.githubusercontent.com/29151932/115942479-2ada8f80-a4b3-11eb-9961-f9457f252ceb.png)

Şifrenin kırılmasını zorlaştırmak için şifrenin her sırası için bir döngü oluşturulmuştur. 3 ve 7 için oluşturulan döngülerde aynı satırların farklı döngülerde olduğu görülmüş ve bu özelliğin çözümlemede kullanılabileceği düşünülmüştür. 

![image](https://user-images.githubusercontent.com/29151932/115942510-50679900-a4b3-11eb-9a50-894fb7df544f.png)

	Sırasındakiler 1. Döngü   
f(x)=7x+1  (mod10)

	Sırasındakiler 1. Ters Döngü   

f^(-1) (x)=3x+⏟7┬(7.1≡7)   (mod10)

	Sırasındakiler 2. Döngü   
f(x)=7x+2  (mod10)

	Sırasındakiler 2. Ters Döngü   

f^(-1) (x)=3x+⏟4┬(7.2=14≡4)   (mod10)

	Sırasındakiler 3. Döngü   
f(x)=7x+3  (mod10)

	Sırasındakiler 3. Ters Döngü   

f^(-1) (x)=3x+⏟1┬(7.3=21≡1)   (mod10)

	Sırasındakiler 4. Döngü   
f(x)=7x+4  (mod10)

	Sırasındakiler 4. Ters Döngü   

f^(-1) (x)=3x+⏟8┬(7.4=28≡8)   (mod10)

	Sırasındakiler 5. Döngü   
f(x)=7x+5  (mod10)

	Sırasındakiler 5. Ters Döngü   

f^(-1) (x)=3x+⏟5┬(7.5=35≡5)   (mod10)



	Sırasındakiler 6. Döngü   
f(x)=7x+6  (mod10)

	Sırasındakiler 6. Ters Döngü   

f^(-1) (x)=3x+⏟2┬(7.6=42≡2)   (mod10)



	Sırasındakiler 7. Döngü   
f(x)=7x+7  (mod10)

	Sırasındakiler 7. Ters Döngü   

f^(-1) (x)=3x+⏟9┬(7.7=49≡9)   (mod10)


	Sırasındakiler 8. Döngü   
f(x)=7x+8  (mod10)

	Sırasındakiler 8. Ters Döngü   

f^(-1) (x)=3x+⏟6┬(7.8=56≡6)   (mod10)


	Sırasındakiler 9. Döngü   
f(x)=7x+9  (mod10)

	Sırasındakiler 9. Ters Döngü   

f^(-1) (x)=3x+⏟3┬(7.9=63≡3)   (mod10)

Şeklinde kodlanmıştır. Bu kodlamaya göre;





40062018 şifresini kodladığımızda
	Döngüde 4→7.4+1=29≡9
	Döngüde 0→7.0+2  =2≡2
	Döngüde 0→7.0+3  =3≡3
	Döngüde 6→7.6+4=46≡6     
	Döngüde 2→7.2+5=19≡9     
	Döngüde 0→7.0+6  =6≡6     
	Döngüde 1→7.1+7=14≡4     
	Döngüde 8→7.8+8=64≡4     


Yani  92369644 seklinde şifrelenecek,
92369644 şifresini çözümlediğimizde ;
	Ters Döngüde 9→3.9+7=34≡4
	Ters Döngüde 2→3.2+4=10≡0
	Ters Döngüde 3→3.3+1=10≡0
	Ters Döngüde 6→3.6+8=26≡6     
	Ters Döngüde 9→3.9+5=32≡2    
	Ters Döngüde 6→3.6+2=20≡0     
	Ters Döngüde 4→3.4+9=21≡1     
	Ters Döngüde 4→3.4+6=18≡8     
Tekrar 40062018 şifresine ulaşılacaktır. 





Benzer şekilde  92369644 şifresi 
	Döngüde 0 giden sayı 
3x+1≡0 (mod10)  
3x≡9 (mod10)
x≡3 (mod10)  
	Döngüde 2 giden sayı  
3x+2≡2 (mod10)  
3x≡0 (mod10)
x≡0 (mod10)  
	Döngüde 3 giden sayı 
3x+3≡3 (mod10)  
3x≡0 (mod10)
x≡0 (mod10)  
	Döngüde 6 giden sayı 
3x+4≡6 (mod10)  
3x≡2 (mod10)
3x≡12 (mod10)  
x≡4 (mod10) 
Yani 3004 şeklinde  çözümlenebilecektir. 



