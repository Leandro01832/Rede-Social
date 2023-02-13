var video = document.getElementsByTagName("iframe");
var duracaoVideo = 0;

if(video.length > 0)
{
    
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
          videoId: video[0].src.replace("https://www.youtube.com/embed/", "").replace("?autoplay=1", ""),
          events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
          }
        });
      }

      // 4. The API will call this function when the video player is ready.
      function onPlayerReady(event) {
       
        duracaoVideo = player.getDuration();
      }

      // 5. The API calls this function when the player's state changes.
      //    The function indicates that when playing a video (state=1),
      //    the player should play for six seconds and then stop.
      var done = false;
      function onPlayerStateChange(event) {
        if (event.data == YT.PlayerState.PLAYING && !done) {
          setTimeout(stopVideo, 6000);
          done = true;
        }
      }
      function stopVideo() {
        player.stopVideo();
      }

   
}

