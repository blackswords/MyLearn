gst-launch-1.0 -v v4l2src device=/dev/video2 ! 'video/x-h264,width=1920,height=1080,framerate=30/1' ! rtph264pay ! udpsink clients="192.168.1.102:5600"

<br>
<br>

Test on 
Gstreamer 1.16.0
（1.18.0 test success）

<br>
<br>
An example to How use opencv to catch gstreamer push stream.