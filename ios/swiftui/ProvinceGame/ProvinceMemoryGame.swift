//
//  ProvinceMemoryGame.swift
//  ProvinceGame
//
//  Created by 不正 on 2020/11/6.
//

import SwiftUI

class ProvinceMemoryGame: ObservableObject {
    @Published private var model: MemoryGame<String, String> = ProvinceMemoryGame.createMemoryGame()
    @Published private var count: Int = 0
    
    static func createMemoryGame() ->MemoryGame<String, String> {
        let central: Array<(String, String)> = [
            ("河北", "石家庄"),("山东", "济南"), ("吉林", "长春"), ("黑龙江", "哈尔滨"), ("辽宁", "沈阳"), ("内蒙古", "呼和浩特"), ("新疆", "乌鲁木齐"), ("甘肃", "兰州"), ("宁夏", "银川"), ("山西", "太原"), ("陕西", "西安"), ("河南", "郑州"), ("安徽", "合肥"), ("江苏", "南京"), ("浙江", "杭州"), ("福建", "福州"), ("广东", "广州"), ("江西", "南昌"), ("海南", "海口"), ("广西", "南宁"), ("贵州", "贵阳"), ("湖南", "长沙"), ("湖北", "武汉"), ("四川", "成都"), ("云南", "昆明"), ("西藏", "拉萨"), ("青海", "西宁"), ("台湾", "台北"), 
        ]
        return MemoryGame<String, String>(numberOfPairOfCards: central.count){
            index in
            return central[index]
        }
    }
    
    var cards: Array<MemoryGame<String, String>.Card> {
        model.cards
    }
    var cnt: Int{
        count
    }
    
    func addCount(){
        count += 1
        count %= model.cards.count
    }
    func lookit(card: MemoryGame<String, String>.Card){
        model.lookAnswer(card: card)
    }
}
