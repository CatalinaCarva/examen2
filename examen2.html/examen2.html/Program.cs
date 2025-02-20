﻿
namespace examen2.html
{
    internal class Program
    {
        static void Main(string[] args)
        {
            @import url('https://fonts.googleapis.com/css?family=Roboto:400,300,100,500');

            body, html {
            margin: 0;
            height: 100 %;
                font - family: 'Roboto', sans - serif;
            }

            input, button {
            border: none;
            outline: none;
            }

::- webkit - input - placeholder {
            color: rgba(255, 255, 255, 0.65);
            }

.highlight {
            color: rgba(255, 255, 255, 0.8);
                font - weight: 400;
            cursor: pointer;
            transition: color 0.2s ease;
            }

.highlight: hover {
            color: #fff;
    transition: color 0.2s ease;
            }

.spacing {
                flex - grow: 1;
            height: 120px;
                font - weight: 300;
                text - align: center;
                margin - top: 10px;
            color: rgba(255, 255, 255, 0.65);
            }

.input - line:focus {
            outline: none;
                border - color: #fff;
    transition: all 0.2s ease;
            }

.ghost - round {
            cursor: pointer;
            background: none;
            border: 1px solid rgba(255, 255, 255, 0.65);
                border - radius: 25px;
            color: rgba(255, 255, 255, 0.65);
                align - self: flex - end;
                font - size: 1.2rem;
                font - weight: 300;
                line - height: 2.5em;
                margin - top: auto;
                margin - bottom: 25px;
            transition: all 0.2s ease;
            }

.ghost - round:hover {
            background: rgba(255, 255, 255, 0.15);
            color: #fff;
    transition: all 0.2s ease;
            }

.input - line {
            background: none;
                margin - bottom: 10px;
                line - height: 2.4em;
            color: #fff;
    font - weight: 300;
                letter - spacing: 0.02rem;
                font - size: 1.2rem;
                border - bottom: 1px solid rgba(255, 255, 255, 0.65);
            transition: all 0.2s ease;
            }

.full - width {
            width: 100 %;
            }

.input - fields {
                margin - top: 25px;
            }

.container {
            display: flex;
                align - items: center;
                justify - content: center;
            background: #eee;
    height: 100 %;
            }

.content {
            padding: 0 25px;
            display: flex;
                flex - direction: column;
                z - index: 5;
            }

.welcome {
                font - weight: 200;
                margin - top: 75px;
                text - align: center;
                font - size: 2.5rem;
                letter - spacing: 0.05rem;
            }

.subtitle {
                text - align: center;
                line - height: 1em;
                font - weight: 100;
                letter - spacing: 0.02rem;
            }

.menu {
            background: rgba(0, 0, 0, 0.2);
            width: 100 %;
            height: 50px;
            }

.window {
                z - index: 100;
            color: #fff;
    position: relative;
            display: flex;
                flex - direction: column;
                box - shadow: 0px 15px 50px 10px rgba(0, 0, 0, 0.2);
                box - sizing: border - box;
            height: 560px;
            width: 360px;
            background: url("https://pexels.imgix.net/photos/27718/pexels-photo-27718.jpg?fit=crop&w=1280&h=823") top left no - repeat;
            }

.overlay {
            background: linear - gradient(#8ca6db, #b993d6);
    opacity: 0.85;
            height: 560px;
            position: absolute;
            width: 360px;
                z - index: 1;
            }

.bold - line {
            background: #e7e7e7;
    position: absolute;
            top: 0;
            bottom: 0;
            margin: auto;
            width: 100 %;
            height: 360px;
                z - index: 1;
            opacity: 0.1;
            background: url("https://pexels.imgix.net/photos/27718/pexels-photo-27718.jpg?fit=crop&w=1280&h=823") left no-repeat;
                background - size: cover;
            }

            @media(max - width: 500px) {
    .window, .overlay {
                width: 100 %;
                height: 100 %;
                }
            }
        }
    }
}
