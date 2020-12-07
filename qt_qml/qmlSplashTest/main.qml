import QtQuick 2.12
import QtQuick.Window 2.12

Item {
    id: root

    Splash{
        id: splashScreen
    }

    Loader {
        id: loader
        asynchronous: true
        source: "qrc:/MainView.qml"
        active: false
    }

    Timer{
        id: timer
        interval: 1000; running: false; repeat: false;
        onTriggered: {
            if(loader.loaded){
                loader.item.showtime()
                splashScreen.delay()
            }
            else{
                interval = 200;
                start();
            }
        }
    }


    Component.onCompleted: {
        timer.start()
        loader.active = true
    }
}
