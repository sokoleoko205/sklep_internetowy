import React, { useState } from 'react';
import './App.css';


const App = () => {
  const [produkty, setProdukty]=useState({
  
      zdjecie: ["iphone13.jfif", "samsung_galaxy_s21.jpg", "xiaomi_redmi_note_10.jpg", "oneplus_9_pro.png", "google_pixel_6.jpg", "sony_xperia_5.jpg", "huawei_p40_pro.jpg", "nokia_8.3.jpg", "oppo_find_x3.jpg"],
      nazwa: ["Apple Iphone 13", "Samsung Galaxy S21", "Xiaomi Redmi Note 10", "OnePlus 9 Pro", "Google Pixel 6", "Sony Xperia 5", "Huawei P40 Pro", "Nokia 8.3", "Oppo Find X3"],
      ocena: ["4,5", "4,7", "4,6", "4,8", "4,5", "4,4", "4,6", "4,3", "4,5"],
      liczbaocen: ["Opinie: 1337", "Opinie: 850", "Opinie: 1200", "Opinie: 675", "Opinie: 400", "Opinie: 250", "Opinie: 950", "Opinie: 500", "Opinie: 300"],
      opis: ["lorem ipsum lorem ipsum", "Lorem ipsum dolor sit amet.", "Lorem ipsum dolor sit amet.", "Lorem ipsum dolor sit amet.", "Lorem ipsum dolor sit amet.", "Lorem ipsum dolor sit amet.", "Lorem ipsum dolor sit amet.", "Lorem ipsum dolor sit amet.", "Lorem ipsum dolor sit amet."],
      cena: ["Cena: 2137,00 zł", "Cena: 2899,00 zł", "Cena: 999,00 zł", "Cena: 3599,00 zł", "Cena: 2699,00 zł", "Cena: 2999,00 zł", "Cena: 2999,00 zł", "Cena: 1999,00 zł", "Cena: 3499,00 zł"]

    


  });

  return (
    <div>
    <div>
  {Object.values(produkty.zdjecie).map((_, index) => (
    <div className='produkt' id={index} key={index}>
      <img id="zdjecie" src={produkty.zdjecie[index]} alt={produkty.nazwa[index]} />
      <h3 id="nazwa">{produkty.nazwa[index]}</h3>
      <p id="gwiazdki" className={produkty.ocena[index]}></p>
      <p id="ocena">{produkty.liczbaocen[index]}</p>
      <p id="opis">{produkty.opis[index]}</p>
      <p id="cena">{produkty.cena[index]}</p>
    </div>
  ))}
</div>

      
        
    </div>
  );
};

export default App;
