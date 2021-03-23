<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Glavna.aspx.cs" Inherits="Parking_web.Glavna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Elektronski parking servis</title>
    <meta name="description" content="Free Bootstrap Theme by BootstrapMade.com">
    <meta name="keywords" content="free website templates, free bootstrap themes, free template, free bootstrap, free website template">
    <link href='https://fonts.googleapis.com/css?family=Lato:400,700,300|Open+Sans:400,600,700,300' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="css/font-awesome.min.css">
    <link rel="stylesheet" type="text/css" href="css/animate.css">
    <link rel="stylesheet" type="text/css" href="css/style.css">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,700,300' rel='stylesheet' type='text/css'>

</head>
<body>
  <!--header-->
  <form id="form1" runat="server">
  <header class="main-header" id="header">
    <div class="bg-color">
      <!--nav-->
      <nav class="nav navbar-default navbar-fixed-top">
        <div class="container">
          <div class="col-md-12">
            <div class="navbar-header">
              <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#mynavbar" aria-expanded="false" aria-controls="navbar">
                            <span class="fa fa-bars"></span>
                        </button>
              <a href="Glavna.aspx" class="navbar-brand">Elektronski parking sistem</a>
            </div>
            <div class="collapse navbar-collapse navbar-right" id="mynavbar">
              <ul class="nav navbar-nav">
                <li class="active"><a href="#header">Početna</a></li>
                <li><a href="#feature">Cene usluga</a></li>
                <li><a href="#pricePlans">Sniženja</a></li>
                <li><a href="#contact">Kontakt</a></li>
                <li><a href="Logovanje.aspx">Prijavi se</a></li>
                <!--li><a href="#portfolio">Portfolio</a></li>
                <li><a href="#contact">Contact</a></li-->
              </ul>
            </div>
          </div>
        </div>
      </nav>
      <!--/ nav-->
      <div class="container text-center">
        <div class="wrapper wow fadeInUp delay-05s">
          <h2 class="top-title" style="margin-top:90px">Dobrodošli na</h2>
          <h3 class="title">ElPS</h3>
          <h4 class="sub-title">Obezbedite svoje parking mesto na vreme</h4>        
          <asp:Button  class="btn btn-send" runat="server" Text="Rezerviši" id="btnRez1" OnClicK="btnRezervisi_Click"></asp:Button>       
        </div>
      </div>
    </div>
  </header>
  <!--/ header-->
  <!--SLOGAN-->
  <section id="cta-1">
    <div class="container">
      <div class="row">
        <div class="cta-info text-center">
          <h3><span class="dec-tec">“</span>Uštedite novac, a i vaše vreme. Rezervišite svoje mesto, zaboravite na probleme.<span class="dec-tec">”</span> - Beautiful Minds Team</h3>
        </div>
      </div>
    </div>
  </section>
  <!--CENE USLUGA I SLIKE-->
  <section id="feature" class="section-padding">
  <div class="container">
        <h2 class="head-title"><img class="slika" src="img/coins.png"/>Cene usluga</h2>
        <hr class="botm-line"/>
      <div class="row1">
        <!--div class="col-md-3 wow fadeInLeft delay-05s">
          <div class="section-title">
            <h2 class="head-title">Cene usluga</h2>
            <hr class="botm-line"/>
            <p class="sec-para">Prikaz trenutnih cena usluga parking servisa po tipu vozila.</p>
          </div>
        </div-->
        <div class="col-md-9">
          <div class="col-md-6 wow fadeInRight delay-02s">
            <div class="icon">
              <img class="slika" src="img/car.png"/>
            </div>
            <div class="icon-text">
              <h3 class="txt-tl">Automobili</h3>
              <table>
    <thead>
        <tr>
            <th>Usluga</th>
            <th>Cena</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td >Jednočasovna</td>
            <td id="auto1h" runat="server">23</td>
        </tr>
        <tr>
            <td >Poludnevna</td>
            <td id="auto12h" runat="server">34</td>
        </tr>
        <tr>
            <td >Dnevna</td>
            <td id="auto24h" runat="server">32</td>
        </tr>
        <tr>
            <td >Nedeljna</td>
            <td id="auto168h" runat="server">18</td>
        </tr>
        <tr>
            <td >Mesečna</td>
            <td id="auto720h" runat="server">18</td>
        </tr>
    </tbody>
</table>
            </div>
          </div>
          <div class="col-md-6 wow fadeInRight delay-02s">
            <div class="icon">
              <img class="slika" src="img/truck.png"/>
            </div>
            <div class="icon-text">
              <h3 class="txt-tl">Kamioni</h3>
              <table>
    <thead>
        <tr>
            <th>Usluga</th>
            <th>Cena</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td >Jednočasovna</td>
            <td id="kamion1h" runat="server">23</td>
        </tr>
        <tr>
            <td >Poludnevna</td>
            <td id="kamion12h" runat="server">34</td>
        </tr>
        <tr>
            <td >Dnevna</td>
            <td id="kamion24h" runat="server">32</td>
        </tr>
        <tr>
            <td >Nedeljna</td>
            <td id="kamion168h" runat="server">18</td>
        </tr>
        <tr>
            <td >Mesečna</td>
            <td id="kamion720h" runat="server">18</td>
        </tr>
    </tbody>
</table>
            </div>
          </div>
          <div class="col-md-6 wow fadeInRight delay-04s">
            <div class="icon">
              <img class="slika" src="img/bus.png"/>
            </div>
            <div class="icon-text">
              <h3 class="txt-tl">Autobusi</h3>
              <table>
    <thead>
        <tr>
            <th>Usluga</th>
            <th>Cena</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td >Jednočasovna</td>
            <td id="autobus1h" runat="server">23</td>
        </tr>
        <tr>
            <td >Poludnevna</td>
            <td id="autobus12h" runat="server">34</td>
        </tr>
        <tr>
            <td >Dnevna</td>
            <td id="autobus24h" runat="server">32</td>
        </tr>
        <tr>
            <td >Nedeljna</td>
            <td id="autobus168h" runat="server">18</td>
        </tr>
        <tr>
            <td>Mesečna</td>
            <td id="autobus720h" runat="server">18</td>
        </tr>
    </tbody>
</table>
            </div>
          </div>
        </div>
      </div>
    </div>
  <!--SLIKE-->
  <section class="section-padding wow fadeInUp delay-02s" id="portfolio">
    <div class="container">
      <div class="row">
        <div class="col-md-3 col-sm-12">
          <div class="section-title">
            <h2 class="head-title" id="naslovKodSlike">Slike naših garaža</h2>
            <hr class="botm-line">
          </div>
        </div>
        <div class="col-md-9 col-sm-12">
          <div class="col-md-4 col-sm-6 padding-right-zero">
            <div class="portfolio-box design">
              <img src="img/port01.jpg" alt="" class="img-responsive">
            </div>
          </div>
          <div class="col-md-4 col-sm-6 padding-right-zero">
            <div class="portfolio-box design">
              <img src="img/port02.jpg" alt="" class="img-responsive">
            </div>
          </div>
          <div class="col-md-4 col-sm-6 padding-right-zero">
            <div class="portfolio-box design">
              <img src="img/port03.jpg" alt="" class="img-responsive">
            </div>
          </div>
          <div class="col-md-4 col-sm-6 padding-right-zero">
            <div class="portfolio-box design">
              <img src="img/port04.jpg" alt="" class="img-responsive">
            </div>
          </div>
          <div class="col-md-4 col-sm-6 padding-right-zero">
            <div class="portfolio-box design">
              <img src="img/port05.jpg" alt="" class="img-responsive">
            </div>
          </div>
          <div class="col-md-4 col-sm-6 padding-right-zero">
            <div class="portfolio-box design">
              <img src="img/port06.jpg" alt="" class="img-responsive">
            </div>
          </div>
        </div>
        </div>
     </div>
  </section>
  <!--SLOBODNA MESTA-->
  <div class="container">
        <h2 class="head-title"><img class="slika" src="img/slobodna.png"   style="height:76px";/>Slobodna parking mesta</h2>
        <hr class="botm-line"/>
      <div class="row1">
       
        <div class="col-md-9">
          <div class="col-md-6 wow fadeInRight delay-02s">
            <div class="icon">
            
            </div>
            <div class="icon-text">
              <h3 class="txt-tl"></h3>
              <table>
    <thead>
        <tr>
            <th>Garaža 1 </th>
            <th>Broj mesta</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td ><img class="slika" src="img/car.png"/>Automobili</td>   
            <td id="Td1" runat="server"></td>
        </tr>
        <tr>
            <td ><img class="slika" src="img/invalid.png"/>Atomobili sa invaliditetom</td>
         
            <td id="Td2" runat="server"></td>
        </tr>
        <tr>
            <td ><img  class="slika" src="img/bus.png"/>Autobus</td>
            <td id="Td3" runat="server"></td>
        </tr>
        <tr>
            <td ><img class="slika" src="img/truck.png"/>Kamion</td>
            <td id="Td4" runat="server"></td>
        </tr>        
    </tbody>
</table>
            </div>
          </div>
          <div class="col-md-6 wow fadeInRight delay-02s">
            <div class="icon">             
            </div>
            <div class="icon-text">
              <h3 class="txt-tl"></h3>
              <table>
    <thead>
        <tr>
            <th>Garaža 2</th>
            <th>Broj mesta</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td ><img class="slika" src="img/car.png"/>Automobili</td>           
            <td id="Td5" runat="server"></td>
        </tr>
        <tr>
            <td ><img class="slika" src="img/invalid.png"/>Atomobili sa invaliditetom</td>
         
            <td id="Td6" runat="server"></td>
        </tr>
        <tr>
            <td ><img  class="slika" src="img/bus.png"/>Autobus</td>
            <td id="Td7" runat="server"></td>
        </tr>
        <tr>
            <td ><img class="slika" src="img/truck.png"/>Kamion</td>
            <td id="Td8" runat="server"></td>
        </tr>        
    </tbody>
</table>
            </div>
          </div>
          <div class="col-md-6 wow fadeInRight delay-04s">
            <div class="icon">              
            </div>
            <div class="icon-text">
              <h3 class="txt-tl"></h3>
              <table>
    <thead>
        <tr>
            <th>Garaža 3</th>
            <th>Broj mesta</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td ><img class="slika" src="img/car.png"/>Automobili</td>           
            <td id="Td9" runat="server"></td>
        </tr>
        <tr>
            <td ><img class="slika" src="img/invalid.png"/>Atomobili sa invaliditetom</td>
         
            <td id="Td10" runat="server"></td>
        </tr>
        <tr>
            <td ><img  class="slika" src="img/bus.png"/>Autobus</td>
            <td id="Td11" runat="server"></td>
        </tr>
        <tr>
            <td ><img class="slika" src="img/truck.png"/>Kamion</td>
            <td id="Td12" runat="server"></td>
        </tr>        
    </tbody>
</table>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!--BANER-->
  <section class="section-padding parallax bg-image-2 section wow fadeIn delay-08s" id="cta-2">
    <div class="container">
      <div class="row">
        <div class="col-md-8">
          <div class="cta-txt">
            <h3>U potrazi ste za parking mestom?</h3>
            <p>Pridružite se hiljadama zadovoljnih korisnika usluga našeg Elektronskog parking sistema!</p>
          </div>
        </div>
        <div class="col-md-4 text-center">          
          <a href="Logovanje.aspx" class="btn btn-submit">Rezerviši sada</a>
        </div>
      </div>
    </div>
  </section>
  <!---->
  <!--OBAVESTENJE I SNIZENJA-->
  <section class="section-padding wow fadeInUp delay-02s" id="portfolio1">
    <div class="container">
      <div class="row">
        <div class="col-md-33 col-sm-12">
          <div class="section-title">
            <h2 class="head-title" id="obavestenje">Redovno pratite naš sajt kako biste bili u toku sa najnovijim aktuelnostima Elektronskog parking sistema.</h2>
            <hr class="botm-line">
          </div>
        </div>

   <!--SNIZENJA-->
     <section id="pricePlans">
       <h2 class="bestPlanTitle"> <img class="slika" src="img/snizenja3.png"/;/> Sniženja </h2>
		<ul id="plans">
			<li class="plan" style="margin-left:60px;">
				<ul class="planContainer">
					<li class="title1"><h2> <img  class="slika" src="img/bus.png"/></h2></li>
					<li class="price"><p>Autobusi</p></li>
					<li>
						<ul class="options">
                             <label ID="LabelBus" runat="server"></label>
						</ul>
					</li>
					<li class="button"><a href="Logovanje.aspx">Rezerviši</a></li>
				</ul>
			</li>

			<li class="plan">
				<ul class="planContainer">
					<li class="title1"><h2 class="bestPlanTitle"><img class="slika" src="img/car12.png"/></h2></li>
					<li class="bestprice"><p class="bestPlanPrice">Automobili</p></li>
					<li>
						<ul class="options">
                           <label ID="Label1" runat="server"></label>
						</ul>
					</li>
					<li class="button"><a class="bestPlanButton" href="Logovanje.aspx">Rezerviši</a></li>
				</ul>
			</li>
			<li class="plan">
				<ul class="planContainer">
					<li class="title1"><h2><img class="slika" src="img/truck.png"/></h2></li>
					<li class="price"><p>Kamioni</p></li>
					<li>
						<ul class="options">
                            <label ID="LabelTruck" runat="server"></label>
						</ul>
					</li>
					<li class="button"><a href="Logovanje.aspx">Rezerviši</a></li>
				</ul>
			</li>
		</ul>		
	</section>

      </div>
    </div>
  </section>
  <!---->
  <!--KONTAKT-->
  <section class="section-padding wow fadeInUp delay-05s" id="contact">
    <div class="container">
      <div class="row white">
        <div class="col-md-8 col-sm-12">
          <div class="section-title">
            <h2 class="head-title black">Kontaktirajte nas</h2>
            <hr class="botm-line"/>
            <p class="sec-para black">Za sva dodatna pitanja i informacije u vezi poslovanja Elektronskog parking servisa obratite se na e-mail ili pozivom na kontakt telefon.</p>
          </div>
        </div>

        <div class="col-md-12 col-sm-12">
          <div class="col-md-4 col-sm-6" style="padding-left:0px;">
            <h3 class="cont-title">E-mail </h3>
            <div id="sendmessage">Vaš e-mail je poslat. Hvala Vam!</div>
            <div id="errormessage"></div>
            <div class="contact-info">           
                <div class="form-group">
                  <input type="text" name="name" class="form-control" id="name" runat="server" placeholder="Ime" autocomplete="off" data-rule="minlen:4" data-msg="Please enter at least 4 chars" />
                  <div class="validation"></div>
                </div>
                <div class="form-group">
                  <input type="email" class="form-control" name="email" id="email" runat="server" placeholder="Vaš Email" autocomplete="off" data-rule="email" data-msg="Please enter a valid email" />
                  <div class="validation"></div>
                </div>
                <div class="form-group">
                  <input type="password" class="form-control" name="password" id="password" runat="server" placeholder="Lozinka" data-rule="password" data-msg="Please enter a valid password" />
                  <div class="validation"></div>
                </div>
                <div class="form-group">
                  <input type="text" class="form-control" name="subject" id="subject" runat="server" placeholder="Predmet" autocomplete="off" data-rule="minlen:4" data-msg="Please enter at least 8 chars of subject" />
                  <div class="validation"></div>
                </div>
                <div class="form-group">
                  <textarea class="form-control" name="message" id="message1" runat="server" rows="5" data-rule="required"  data-msg="Please write something for us" placeholder="Message"></textarea>
                  <div class="validation"></div>
                </div>
                <asp:Button  class="btn btn-send" runat="server" Text="Pošalji" id="btnLogin" OnClicK="btnLogin_Click"></asp:Button>              
            </div>

          </div>
          <div class="col-md-4 col-sm-6">
            <h3 class="cont-title">Posetite nas</h3>
            <div class="location-info">
              <p class="white"><span aria-hidden="true" class="fa fa-map-marker"></span>Aleksandra Medvedeva 14</p>
              <p class="white"><span aria-hidden="true" class="fa fa-phone"></span>Telefon: +381 (18) 529-105</p>
              <p class="white"><span aria-hidden="true" class="fa fa-envelope"></span>Email: <a href="" class="link-dec">efinfo@elfak.ni.ac.rs</a></p>
               <p><div class="contact-icon-container hidden-md hidden-sm hidden-xs">
              <span aria-hidden="true" class="fa fa-envelope-o"></span>
            </div></p>
            </div>
          </div>
          <div class="col-md-4">
          <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2902.18603759699!2d21.890333315448974!3d43.331295979133614!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4755b733e02e006f%3A0x2fd8f95c1eacfcfb!2sFaculty+of+Electronic+Engineering!5e0!3m2!1sen!2srs!4v1558884267480!5m2!1sen!2srs" 
                width="400" height="400" frameborder="0" style="border:0" allowfullscreen></iframe>            
          </div>
        </div>
      </div>
    </div>
  </section>
  <!--FOOTER-->
  <footer class="" id="footer">
    <div class="container">
      <div class="row">
          <div class="col-sm-7 footer-copyright">
          © Elektronski fakultet Univerzitet u Nišu
          <div class="credits">
             Designed by <span style="color:#FFD34E">Beautiful Minds Team</span>
          </div>
        </div>
        <div class="col-sm-5 footer-social">
          <div class="pull-right hidden-xs hidden-sm">
            <img src="img/logoelfak.png"/>
          </div>
        </div>
      </div>
    </div>
  </footer>
  <!---->
  <!--contact ends-->
  <script src="js/jquery.min.js"></script>
  <script src="js/jquery.easing.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/wow.js"></script>
  <script src="js/custom.js"></script>
  <script src="contactform/contactform.js"></script>
  </form>
</body>
</html>
