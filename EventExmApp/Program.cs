﻿// See https://aka.ms/new-console-template for more information
using EventExmApp;

Console.WriteLine("Hello, World!");

var video = new Video()
{
    Title = "Video 1"
};

var videoEncoder = new VideoEncoder();//publisher
var mailService= new MailService();//subscriber
var messageService = new MessageService();//subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

videoEncoder.Encode(video);
