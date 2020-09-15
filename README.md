# Stomatološka ordinacija
# https://github.com/sinansubara/StomatoloskaOrdinacijaDocker

# 
# Username: Administrator | Password: test
# MedicinskoOsoblje | Password: test
# Stomatolog | Password: test
# Pacijent | Password: test
#
#####################################################################################
# Za testiranje, prvo treba pokrenuti WebApi preko dockera
# Odraditi "docker-compose build"
# Nakon toga "docker-compose up"
# Kada server bude pokrenut, pokrenemo u visual studiu WinUI(Desktop) ili UWP(Mobile) projekt
# Ako se desi error pri pokretanju dockera(docker-compose up), drugi način za testiranje je, da u set startup projects, stavimo API, UWP i WinUI
# Automatski će se generisati baza podataka na localhostu, bilo da se pokrene preko dockera ili direktno iz visual studia
######################################################################################
# Dodatni Admin acc Username: subarasinan | Password: test
# --------------------------------------------------------------

## Za testiranje funkcionalnosti "Zaboravljena lozinka", potrebno je
> nakon unosa maila za slanje koda(na formi za zaboravljenu lozinku),
> ući na gmail akaunt od aplikacije(pristupni podaci se nalaze u appsettings)
> i pronaći u "SENT" dijelu zadnji poslani mail, jer svi mailovi od korisnika su izmisljeni
> i ne mogu se isporučiti, ali ako mail postoji, naravno mail će se isporučiti na adresu.
> Uzimanjem koda koji je poslat na adresu, popunjavamo formu za izmjenu lozinke sa tim kodom

## Za testiranje funkcionalnosti plaćanja računa
> Koristiti kartice samo sa ovog linka https://stripe.com/docs/testing#international-cards
> Samo one su validne za testiranje ove funkcionalnosti

## Za testiranje funkcionalnosti Skeniranje QR Code
> Trebate imati neku kameru konektovanu na PC, 
> možete se spojiti i s telefonom preko aplikacije "iVCam"
> Generisanje koda će se obaviti automatski nakon izvršenja transakcije plaćanja računa
