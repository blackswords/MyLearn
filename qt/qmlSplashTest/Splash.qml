import QtQuick 2.0
import QtQuick.Window 2.3

Window {
    id: splash
    color: "transparent"
    title: "Splash Window"
    modality: Qt.ApplicationModal
    flags: Qt.SplashScreen | Qt.WindowStaysOnTopHint

    x: (Screen.width - splashImage.width) / 2
    y: (Screen.height - splashImage.height) / 2
    width: splashImage.width
    height: splashImage.height


    property bool timeout: false

    Image {
        id: splashImage
        source: "res/1.png"
    }

    Text {
        id: textCtrl
        text: qsTr("text")
    }

    function delay(){
        visible = false;
    }

    Component.onCompleted: visible = true

}
