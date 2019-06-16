<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title >
	房产信息系统
    </title>
   
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,700' rel='stylesheet' type='text/css'/>
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"/>

    <link rel="stylesheet" href="css/normalize.css"/>




    <style>
        /* NOTE: The styles were added inline because Prefixfree needs access to your styles and they must be inlined if they are on local disk! */
        body {
            font-family: "Open Sans", sans-serif;
            height: 100vh;
            background: url("http://i.imgur.com/HgflTDf.jpg") 50% fixed;
            background-size: cover;
        }

        @keyframes spinner {
            0% {
                transform: rotateZ(0deg);
            }

            100% {
                transform: rotateZ(359deg);
            }
        }

        * {
            box-sizing: border-box;
        }

        .wrapper {
            display: flex;
            align-items: center;
            flex-direction: column;
            justify-content: center;
            width: 100%;
            min-height: 100%;
            padding: 20px;
            background: rgba(4, 40, 68, 0.85);
        }
          .wrapper1 {
            display: flex;
            align-items: center;
            flex-direction: column;
            justify-content: center;
            width: 100%;
            min-height: 100%;
            padding: 20px;
            background: rgba(135,206,235, 0.85);
           

        }

        .login {
            border-radius: 2px 2px 5px 5px;
            padding: 10px 20px 20px 20px;
            width: 90%;
            max-width: 320px;
            background: #ffffff;
            position: relative;
            padding-bottom: 80px;
            box-shadow: 0px 1px 5px rgba(0, 0, 0, 0.3);
        }

            .login.loading button {
                max-height: 100%;
                padding-top: 50px;
            }

                .login.loading button .spinner {
                    opacity: 1;
                    top: 40%;
                }

            .login.ok button {
                background-color: #8bc34a;
            }

                .login.ok button .spinner {
                    border-radius: 0;
                    border-top-color: transparent;
                    border-right-color: transparent;
                    height: 20px;
                    animation: none;
                    transform: rotateZ(-45deg);
                }

            .login input {
                display: block;
                padding: 15px 10px;
                margin-bottom: 10px;
                width: 100%;
                border: 1px solid #ddd;
                transition: border-width 0.2s ease;
                border-radius: 2px;
                color: #ccc;
            }

                .login input + i.fa {
                    color: #fff;
                    font-size: 1em;
                    position: absolute;
                    margin-top: -47px;
                    opacity: 0;
                    left: 0;
                    transition: all 0.1s ease-in;
                }

                .login input:focus {
                    outline: none;
                    color: #444;
                    border-color: #2196F3;
                    border-left-width: 35px;
                }

                    .login input:focus + i.fa {
                        opacity: 1;
                        left: 30px;
                        transition: all 0.25s ease-out;
                    }

            .login a {
                font-size: 0.8em;
                color: #2196F3;
                text-decoration: none;
            }

            .login .title {
                color: #444;
                font-size: 1.2em;
                font-weight: bold;
                margin: 10px 0 30px 0;
                border-bottom: 1px solid #eee;
                padding-bottom: 20px;
            }

            .login button {
                width: 100%;
                height: 100%;
                padding: 10px 10px;
                background: #2196F3;
                color: #fff;
                display: block;
                border: none;
                margin-top: 20px;
                position: absolute;
                left: 0;
                bottom: 0;
                max-height: 60px;
                border: 0px solid rgba(0, 0, 0, 0.1);
                border-radius: 0 0 2px 2px;
                transform: rotateZ(0deg);
                transition: all 0.1s ease-out;
                border-bottom-width: 7px;
            }

                .login button .spinner {
                    display: block;
                    width: 40px;
                    height: 40px;
                    position: absolute;
                    border: 4px solid #ffffff;
                    border-top-color: rgba(255, 255, 255, 0.3);
                    border-radius: 100%;
                    left: 50%;
                    top: 0;
                    opacity: 0;
                    margin-left: -20px;
                    margin-top: -20px;
                    animation: spinner 0.6s infinite linear;
                    transition: top 0.3s 0.3s ease, opacity 0.3s 0.3s ease, border-radius 0.3s ease;
                    box-shadow: 0px 1px 0px rgba(0, 0, 0, 0.2);
                }

            .login:not(.loading) button:hover {
                box-shadow: 0px 1px 3px #2196F3;
            }

            .login:not(.loading) button:focus {
                border-bottom-width: 4px;
            }

        footer {
            display: block;
            padding-top: 50px;
            text-align: center;
            color: #ddd;
            font-weight: normal;
            text-shadow: 0px -1px 0px rgba(0, 0, 0, 0.2);
            font-size: 0.8em;
        }

            footer a, footer a:link {
                color: #fff;
                text-decoration: none;
            }
             ul
         {
            list-style-type:none;
            margin:50;
            padding:0;
          }
        
    </style>

    <script src="js/prefixfree.min.js"></script>

</head>
<body style="height: 150px; margin-top: 0px">
     <p>
       <a href="loginform.html"> <input id="Button3" type="button" value="注销" /></a></p>
    <form id="form1" runat="server">
    <!--alert('欢迎" + "username" + ",您成功登录!')-->
    <div class="wrapper1">
            <table>
                
                    房产预约系统

                 </table>   
                   
                   
           
    </div>
    <div class="glo_content" style="background-color:#F0F8FF;height:300px;width:200px;float:left;">
    

       
     
                <UL>
                    <LI style="height: 25px; width: 143px;"><a href="housegl.aspx?staffname">管理预约</a>房产</LI>
                    <LI style="height: 26px; width: 141px;"><a href="addCLIENT.aspx">添加新客户</a></LI>
                    <LI style="height: 26px; width: 137px;"><a href="client.aspx">客户信息</a></LI>
                    <LI style="width: 150px"><a href='key.aspx?&staffname=<%#getstaffname().ToString()%>'>钥匙交接</a></LI>
                    <LI style="width: 150px"><a href='mybook.aspx'>我的预约</a></LI>
                        </UL>
                </div>
        
      <div id="content" style=height:250px;width:800px;float:left;"><iframe src="houseHP.aspx" height="250" frameborder="0" style="width: 862px"></iframe>  </div>
​

    </div>
    </form>
        <div id="footer" style="color:#778899;clear:both;text-align:center;">房屋预约系统</div>
      
</body>
</html>
