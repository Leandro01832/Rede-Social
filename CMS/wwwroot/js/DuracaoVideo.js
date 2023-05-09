var video = document.getElementById("descricao");
var duracaoVideo = 0;
debugger;
if(video.id == "descricao")
{
  var p1 = $("#html").val().split("<iframe");
  var p2 = $("#html").val().split("</iframe>");
  var r = p2[0].replace(p1[0], "");
  var arr = r.split("/");
  var id_video = "";

   for (let index = 0; index < arr.length; index++)
    {
        if(arr[index] == "embed")
        {
          var text = arr[index + 1];
          var arr2 = text.split("?");
          id_video = arr2[0];       
          break;
        }    
   }
  
  var r = r.replace("<iframe width=\"320\" height=\"560\" src=\"https://www.youtube.com/embed/", "");
  var r = r.replace("?autoplay=1\"", "");
      
    // 2. Este código carrega o código API do IFrame Player de forma assíncrona.
     var tag = document.createElement('script');
    
     tag.src = "https://www.youtube.com/iframe_api";
      var firstScriptTag = document.getElementsByTagName('script')[0];
      firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);

      
    
    // 3. Esta função cria um <iframe> (e player do YouTube)
           // após o download do código da API.
     var player;
     function onYouTubeIframeAPIReady() {
        player = new YT.Player('player', {
          height: '560',
          width: '320',
          videoId: id_video,
          events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
          }
        });
      }

      // 4. The API will call this function when the video player is ready.
      function onPlayerReady(event) {
       
        duracaoVideo = player.getDuration();
        document.getElementById("descricao").innerHTML = 
        document.getElementsByTagName("iframe")[0].title;
        event.target.playVideo();
      }

      // 5. The API calls this function when the player's state changes.
      //    The function indicates that when playing a video (state=1),
      //    the player should play for six seconds and then stop.
      var done = false;
      function onPlayerStateChange(event) {
        if (event.data == YT.PlayerState.PLAYING && !done) {
         // setTimeout(stopVideo, 6000);
          done = true;
        }
      }
      function stopVideo() {
        player.stopVideo();
      }

   
}

