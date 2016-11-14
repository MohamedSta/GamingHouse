(function () {
    var video = document.getElementById('video'),

        venderUrl = window.URL || window.webkitURL;

    navigator.getMedia = navigator.getUserMerdia ||
                         navigator.webkitGetUserMedia ||
                         navigator.mozGetUserMedia ||
                         navigator.msGetUserMedia;

    // Capture video
    navigator.getMedia({
        video: true,
        audio: false
    },
        function (stream) {
            video.src = venderUrl.createObjectURL(stream);
            video.play();
        }, function (error) {
            //an error occured 
            // error.code

        });

})();