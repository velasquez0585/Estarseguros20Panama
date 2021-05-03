@modeltype aicweb.capamvc.ErrorModel

@Code
    Layout = Nothing
End Code

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>sitfx.com</title>
	<meta name="keywords" content="SITFX" />
    <link rel="shortcut icon" href='@Url.Content("~/publico/imagenes/sitfx/fav.ico")' />	
    <link href='@Url.Content("~/publico/css/errores.css")' rel="stylesheet" type="text/css" />
</head>
<body>

	<div id="container">
		<a href="http://www.sitfx.com" id="logo"><img alt="sitfx" src='@Url.Content("~/publico/imagenes/sitfx/logositfx.png")' /></a>

		<h2>@Model.xtitulo</h2>
        <div id="bar">
            <img alt="" src='@Url.Content("~/publico/imagenes/sitfx/barras.png")' />
        </div>
        <div id="header">
            <p>
                <b>Descripci&oacute;n del error:&nbsp;</b>
                @If (Not Model.xmensaje Is Nothing) Then
                    @Model.xmensaje
                End If
            </p>
        </div>
		<div id="footer">
            <p>
                Por favor recuerde reportarnos este error a <a href="mailto:requerimientos@sitfx.com">
                requerimientos@sitfx.com</a> para 
            </p>
            <p>
                resolverlo de inmediato. Disculpe las molestias ocasionadas.
            </p>
       </div>
	</div>
</body>
</html>
