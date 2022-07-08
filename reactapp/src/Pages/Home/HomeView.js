import React from 'react';
import './Home.css';
function HomeView(props) {
    return (
        <div className="App">
            <p>Hello World {props.count_info} </p>
            <p>{props.children}</p>
        </div>
    );
}
export default HomeView;