<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logovanje.aspx.cs" Inherits="Parking_web.Logovanje" %>

<html lang="en">
<head runat="server">
    <!-- Latest compiled and minified CSS -->
    <title>Logovanje</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="css/styleLogovanje.css">
</head>

<body>
<form runat="server">
<div id="form">
  <div class="container">
    <div class="col-lg-6 col-lg-offset-3 col-md-6 col-md-offset-3 col-md-8 col-md-offset-2">
      <div id="userform">
        <ul class="nav nav-tabs nav-justified" role="tablist">
          <li class="active"><a href="#login"  role="tab" data-toggle="tab">Logovanje</a></li>
          <li><a href="#signup"  role="tab" data-toggle="tab">Registracija</a></li>      
        </ul>
        <div class="tab-content">
           <div class="tab-pane fade active in" id="login">
            <h2 class="text-uppercase text-center"> Logovanje</h2>
            <section id="login1">
              <div class="form-group">                
                <input type="text" class="form-control" id="korisnickoLog" placeholder=" Korisničko ime" required data-validation-required-message="Molimo Vas unesite Vaše korisničko ime." runat="server" autocomplete="off">
                <p class="help-block text-danger"></p>
              </div>
              <div class="form-group">
                <input type="password" class="form-control" id="lozinkaLog" placeholder=" Lozinka" required data-validation-required-message="Molimo Vas unesite Vašu lozinku." runat="server" autocomplete="off">
                <p class="help-block text-danger"></p>
              </div>
              <div class="mrgn-30-top">
                <asp:Button ID="Button1" type="submit" runat="server" class="btn btn-larger btn-block" Text="Uloguj se" OnClick="Button1_Click" UseSubmitBehavior="false"/>
              </div>
            </section>
          </div>
           
          <div class="tab-pane fade in" id="signup">
            <h2 class="text-uppercase text-center"> Registrovanje</h2>
            <section id="signup1">
              <div class="row">
                <div class="col-xs-12 col-sm-6">
                  <div class="form-group">
                    <label> </label>
                    <input type="text" class="form-control" id="first_name" placeholder=" Ime" required data-validation-required-message="Unesite Vaše ime." runat="server" autocomplete="off">
                    <p class="help-block text-danger"></p>
                  </div>
                </div>
                <div class="col-xs-12 col-sm-6">
                  <div class="form-group">
                    <label> </label>
                    <input type="text" class="form-control" id="last_name" placeholder=" Prezime" required data-validation-required-message="Unesite Vaše prezime." runat="server" autocomplete="off">
                    <p class="help-block text-danger"></p>
                  </div>
                </div>
              </div>
              <div class="form-group">
                <label> </label>
                <input type="email" class="form-control" id="email" placeholder=" E-mail" required data-validation-required-message="Unesite Vaš e-mail." runat="server" autocomplete="off">
                <p class="help-block text-danger"></p>
              </div>
              <div class="form-group">
                <label>  </label>
                <input type="text" class="form-control" id="korisnickoReg" placeholder=" Korisničko ime" required data-validation-required-message="Unesite Vaše novo korisničko ime." runat="server" autocomplete="off">
                <p class="help-block text-danger"></p>
              </div>
              <div class="form-group">
                <label>  </label>
                <input type="password" class="form-control" id="lozinkaReg" placeholder="Lozinka" required data-validation-required-message="Unesite Vašu lozinku." runat="server" autocomplete="off">
                <p class="help-block text-danger"></p>
              </div>
              <div class="mrgn-30-top">
                <asp:Button ID="Button2" type="submit" runat="server" class="btn btn-larger btn-block" Text="Registruj se" OnClick="Registracija_Click" UseSubmitBehavior="false" />
              </div>               
            </section>
          </div>
        </div>
      </div>
    </div>
  </div>
  
  <!-- /.container --> 
</div>
    <script>
        $('#form').find('input, textarea').on('keyup blur focus', function (e) {

    var $this = $(this),
        label = $this.prev('label');

    if (e.type === 'keyup') {
        if ($this.val() === '') {
            label.removeClass('active highlight');
        } else {
            label.addClass('active highlight');
        }
    } else if (e.type === 'blur') {
        if ($this.val() === '') {
            label.removeClass('active highlight');
        } else {
            label.removeClass('highlight');
        }
    } else if (e.type === 'focus') {

        if ($this.val() === '') {
            label.removeClass('highlight');
        }
        else if ($this.val() !== '') {
            label.addClass('highlight');
        }
    }

});

$('.tab a').on('click', function (e) {

    e.preventDefault();

    $(this).parent().addClass('active');
    $(this).parent().siblings().removeClass('active');

    target = $(this).attr('href');

    $('.tab-content > div').not(target).hide();

    $(target).fadeIn(800);

});
    </script>
<script src="//code.jquery.com/jquery-1.11.3.min.js"></script>
<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
</form>
</body>
</html>