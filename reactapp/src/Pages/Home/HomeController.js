import React from 'react';
import HomeView from './HomeView'
import HomeModel from './HomeModel'

class HomeController extends React.Component {
    constructor() {
        super();
        this.state = {
          count: 0,
        }; //inicializando o state
        this.homeModel = new HomeModel();//inicializando o view
        this.homeModel.getSomeInfo(); // chamando o metodo do model
        //Inicializando o timeout
        setInterval(() => {
          //atualizando o contador
          this.setState({
            count: this.state.count+1
          })
        }, 1000);
    }
    render() {
      console.log(" Count " + this.state.count);
      return (
          //Chamando o View e passando o props count_info
          <HomeView count_info={this.state.count}> 
              <div> Teste Info </div>
          </HomeView>
      )
    }   
}
export default HomeController;