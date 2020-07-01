<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="RunZe._404" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>404错误</title>
    <meta charset="UTF-8" />
    <link href="css/404.css" rel="stylesheet" />

    <script src="js/jquery.min.js"></script>
    <script src="js/scriptalizer.js"></script>

    <script type="text/javascript">
        $(function () {
            $('#parallax').jparallax({});
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="parallax">
    <div class="error1">
        <img src="image/wand.jpg" alt="Mauer" />
    </div>
    <div class="error2">
        <img src="image/licht.png" alt="Licht" />
    </div>
    <div class="error3">
        <img src="image/halo1.png" alt="Halo1" />
    </div>
    <div class="error4">
        <img src="image/halo2.png" alt="Halo2" />
    </div>
    <div class="error5">
        <img src="image/batman-404.png" alt="Batcave 404" />
    </div>
</div>
<div style="text-align:center;">
<a href="/HomePage.aspx" target="_blank">返回主页</a>
</div>
    </form>
</body>
</html>
