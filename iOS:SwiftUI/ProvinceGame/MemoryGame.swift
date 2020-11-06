//
//  MemoryGame.swift
//  ProvinceGame
//
//  Created by 不正 on 2020/11/6.
//

import Foundation

struct MemoryGame<Question, Answer> {
    var cards: Array<Card>
    
    mutating func lookAnswer(card: Card)  {
        print("Look card: \(card)")
        let chosenIndex = self.index(of: card)
        self.cards[chosenIndex].isLooked = !self.cards[chosenIndex].isLooked
    }
    
    func index(of card: Card) -> Int {
        for index in 0..<self.cards.count {
            if self.cards[index].id  == card.id {
                return index
            }
        }
        return 0
    }
    
    init(numberOfPairOfCards: Int, cardContentFactory: (Int) -> (Question, Answer)) {
        cards = Array<Card>()
        for pairIndex in 0..<numberOfPairOfCards {
            let content = cardContentFactory(pairIndex)
            cards.append( Card( question: content.0 , answer: content.1, id: pairIndex ))
        }
        
    }
    
    
    struct Card: Identifiable {
        var isLooked: Bool = false
        var question: Question
        var answer: Answer
        var id: Int
    }
}
