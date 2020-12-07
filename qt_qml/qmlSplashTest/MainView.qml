import QtQuick 2.0
import QtQuick.Window 2.3
import QtQuick.Controls 2.5

ApplicationWindow {
    id: window
    visible: false
    width: 800
    height: 600
    title: "Splash"
    flags: Qt.Window //| Qt.FramelessWindowHint

    Button{
        id: button
        text: "X"
        height: 50
        width: 50

    }

    Text{
        text: "Text Window"
        anchors.centerIn: parent
        font.pointSize: 30
    }

    function showtime(){
        visible = true;
    }

    //Component.onCompleted: window.show()
}
