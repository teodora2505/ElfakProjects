<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rezervacije.aspx.cs" Inherits="Parking_web.Rezervacije" %>

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
    <link rel="stylesheet" type="text/css" href="css/styleRezervacije.css">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,700,300' rel='stylesheet' type='text/css'>

    <!-- Google font -->
	<link href="https://fonts.googleapis.com/css?family=Raleway:400,700" rel="stylesheet">

    <!-- Bootstrap za rezervacije -->
	<!--link type="text/css" rel="stylesheet" href="css/bootstrap1.min.css" /-->

     <!-- Custom stlylesheet -->
	<link type="text/css" rel="stylesheet" href="css/style1.css" />

</head>
<body>
   <form runat="server" novalidate>
    <!--header-->
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
                <li><a href="#rezervacijeSection">Rezervacije</a></li>
                <li><a href="#produzenjaSection">Produženja</a></li>
                <li><a href="Glavna.aspx">Odjavi se</a></li>
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
          <h3><span class="dec-tec" id="korisnikImePrez" runat="server">Korisnik: Nepoznat</span></h3>
        </div>
      </div>
    </div>
  </section>
  <!---->
       <div id="kraj" style="justify-content: center; flex-wrap: wrap; width: 100%; display: inline-flex;">
       <h2 class="head-title">Podaci o isteku parkiranja:</h2>
       <input type="text" name="name" class="form-control" id="regKraj" runat="server" placeholder="Registracija" autocomplete="off" style="width: auto; margin-top: 23px; margin-bottom: 10px; margin-left: 20px;"/>
       <asp:Button  class="col-md-4 text-center btn btn-send" runat="server" Text="Pošalji" id="Button3" OnClicK="btnKrajParkiranja_Click" style="width: auto; margin: 10px; margin-top: 23px;" ></asp:Button>
       <label runat="server" id="krajLabela" style="margin-top:29px;"></label>
       </div>
  <!--CENE USLUGA-->
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
          <a href="#rezervacijeSection" class="btn btn-submit">Rezerviši sada</a>
        </div>
      </div>
    </div>
  </section>
  <!---->
  <!--REZERVACIJE-->
  <section id="rezervacijeSection" class="section-padding wow fadeInUp delay-02s">
       <div id="booking1" class="section1">
		<div class="section1-center">
			<div class="container">
				<div class="row">
					<div class="booking-form">
						<div class="booking-bg1"></div>
						<section>
							<div class="form-header">
								<h2>Rezervacije</h2>
							</div>
							<div class="form-group">
								<input runat="server" id="tabliceR" class="form-control" type="text" autocomplete="off" placeholder="Registracija vozila">
								<span class="form-label">Registracija vozila</span>
							</div>
							
							<div class="form-group">
								<select id="tipVozilaR" runat="server" class="form-control" required>
									<option value="" label="&nbsp;" selected hidden></option>
									<option>Automobil</option>
									<option>Automobil sa invaliditetom</option>
									<option>Autobus</option>
                                    <option>Kamion</option>
								</select>
								<span class="select-arrow"></span>
								<span class="form-label">Tip vozila</span>
							</div>
                            <div class="form-group">
								<select id="uslugaR" runat="server" class="form-control" required>
									<option value="" label="&nbsp;" selected hidden></option>
									<option>Jednočasovna</option>
									<option>Poludnevna</option>
									<option>Dnevna</option>
                                    <option>Nedeljna</option>
                                    <option>Mesečna</option>
								</select>
								<span class="select-arrow"></span>
								<span class="form-label">Usluga</span>
							</div>
							<div class="form-group">
								<select id="garazaR" runat="server" class="form-control" required>
									<option value="" label="&nbsp;" selected hidden></option>
									<option>1</option>
									<option>2</option>
									<option>3</option>
								</select>
								<span class="select-arrow"></span>
								<span class="form-label">Izaberi garažu</span>
							</div>               
							<div class="row">
								<div class="col-md-6">
									<div class="form-group">
										<input id="datumR" runat="server" class="form-control" type="date" required>
										<span class="form-label">Datum</span>
									</div>
								</div>
								<div class="col-md-6">
									<div class="form-group">
										<input id="vremeR" runat="server" class="form-control" type="time" required>
										<span class="form-label">Vreme</span>
									</div>
								</div>
							</div>
							<div class="form-btn">					
                                <asp:Button ID="Button2" class="submit-btn" runat="server" text="Rezerviši" OnClick="Button2_Click"  />
							</div>
						</section>
					</div>
				</div>
			</div>
		</div>
	</div>


	<script src="js/jquery1.min.js"></script>
	<script>
		$('.form-control').each(function () {
			floatedLabel($(this));
		});

		$('.form-control').on('input', function () {
			floatedLabel($(this));
		});

		function floatedLabel(input) {
			var $field = input.closest('.form-group');
			if (input.val()) {
				$field.addClass('input-not-empty');
			} else {
				$field.removeClass('input-not-empty');
			}
		}
	</script>
    </section>
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
  <!--PRODUZENJA -->
  <section id="produzenjaSection" class="section-padding wow fadeInUp delay-02s">
       <div id="booking" class="section2">
		<div class="section2-center">
			<div class="container">
				<div class="row">
					<div class="booking-form">
						<div class="booking-bg"></div>
						<section>
							<div class="form-header">
								<h2>Produženje parkiranja</h2>
							</div>
							<div class="form-group">
								<input runat="server" id="tablice" class="form-control" type="text" autocomplete="off" placeholder="Registracija vozila">
								<span class="form-label">Registracija vozila</span>
							</div>
							
                            <div class="form-group">
								<select id="UslugaOp" runat="server" class="form-control" required>
									<option value="" label="&nbsp;" selected hidden></option>
									<option>Jednočasovna</option>
									<option>Poludnevna</option>
									<option>Dnevna</option>
                                    <option>Nedeljna</option>
                                    <option>Mesečna</option>
								</select>
								<span class="select-arrow"></span>
								<span class="form-label">Usluga</span>
							</div>
							
							<div class="form-btn">
								<asp:Button ID="Button1" class="submit-btn" runat="server" text="Produži" OnClick="Button1_Click"  />
							</div>
						</section>
					</div>
				</div>
			</div>
		</div>
	</div>


	<script src="js/jquery1.min.js"></script>
	<script>
		$('.form-control').each(function () {
			floatedLabel($(this));
		});

		$('.form-control').on('input', function () {
			floatedLabel($(this));
		});

		function floatedLabel(input) {
			var $field = input.closest('.form-group');
			if (input.val()) {
				$field.addClass('input-not-empty');
			} else {
				$field.removeClass('input-not-empty');
			}
		}
	</script>
    </section>
  <!---->
  <!--KONTAKT-->
  <section class="section-padding wow fadeInUp delay-05s" id="contact">
    <div class="container">
      <div class="row white">
        <div class="col-md-8 col-sm-12">
          <div class="section-title">
            <h2 class="head-title black">Kontaktirajte nas</h2>
            <hr class="botm-line">
            <p class="sec-para black">Za sva dodatna pitanja i informacije u vezi poslovanja Elektronskog parking servisa obratite se na e-mail ili pozivom na kontakt telefon.</p>
          </div>
        </div>

        <div class="col-md-12 col-sm-12">
         <form>
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
                  <textarea class="form-control" name="message" id="message1" runat="server" rows="5" data-rule="required" data-msg="Please write something for us" placeholder="Message"></textarea>
                  <div class="validation"></div>
                </div>
                <asp:Button  class="btn btn-send" runat="server" Text="Pošalji" id="btnLogin" OnClicK="btnLogin_Click"></asp:Button>              
            </div>
          </div>
         </form>

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
