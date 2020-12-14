# Lab-Pizzerian
 Laboration 3: Pizzerian
Khosro Jadidi

Anders Orlinder

I Labben har vi använt oss av ett flertal design pattern: 

Singleton: har använts för att begränsa åtkomsten till vissa delar av koden, som objekt listorna och Factories, för att skydda dem från obehöriga förändringar. 

Factory har använts för att underlätta skapelse av mer komplexa objekt, som pizzor, soda, order rader och order. 

Decorator har vi för att uppdatera innehållet av redan skapade objekt. Som exempel kan vi uppdatera eller ta bort våra order rader. 

Vi även har en liten Visitor som kollar på ingredienserna, och skickar ut de som har ett pris som överstiger 0; 
