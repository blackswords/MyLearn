//
//  ContentView.swift
//  ProvinceGame
//
//  Created by 不正 on 2020/11/6.
//

import SwiftUI

struct ContentView: View {
    @ObservedObject var viewModel: ProvinceMemoryGame
    var count: Int { viewModel.cnt }
    
    
    var body: some View {
        VStack{
            Text("请回答该省的省会：").font(.title3)
            Text(viewModel.cards[count].question).font(.largeTitle).padding(EdgeInsets(top: 30, leading: 0, bottom: 0, trailing: 0)).foregroundColor(.green)
            HStack(alignment: .center, spacing: 20, content: {
                Text("省会是：").padding(EdgeInsets(top: 30, leading: 0, bottom: 0, trailing: 0))
                Text(viewModel.cards[count].isLooked ?  viewModel.cards[count].answer : "???").padding().font(.title)
            })
            
            Button(action:
            {
                self.viewModel.lookit(card: viewModel.cards[count])
            }){
                
                Text(viewModel.cards[count].isLooked ? "隐藏答案" : "显示答案").foregroundColor(.white)
            }.frame(width: /*@START_MENU_TOKEN@*/100/*@END_MENU_TOKEN@*/, height: 50, alignment: .center)
            .background(Color.blue.opacity(0.5))
            .padding()
            .cornerRadius(20)
            .shadow(radius: 10 )
            
            Button(action: {
                self.viewModel.addCount()
            }, label: {
                Text("下一题").foregroundColor(.white)
            }).frame(width: 100.0, height: 40.0)
            .background(Color.blue.opacity(0.6))
            .padding(EdgeInsets(top: 100, leading: 0, bottom: 0, trailing: 0))
//            .background(Color("77FFF9"))
            
        }
        .padding()
    }
}


























struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView(viewModel: ProvinceMemoryGame())
    }
}
