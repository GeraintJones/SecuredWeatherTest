import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'

export class Forecast extends Component {
    static displayName = Forecast.name;

    constructor(props) {
        super(props);
        this.state = { title: null, retrieved: null, forecasts: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    static renderForecastsTable(forecasts) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Date</th>
                        <th>Weather State</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {forecasts.map(forecast =>
                        <tr key={forecast.applicableDate}>
                            <td>{forecast.applicableDate}</td>
                            <td>{forecast.weatherStateName}</td>
                            <td><img src={forecast.weatherStateImageUrl} width="25" /></td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    refresh() {
        window.location.reload();
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Forecast.renderForecastsTable(this.state.forecasts);

        return (
            <div>
                <h1 id="tabelLabel" >Weather forecast</h1>
                <h6>For {this.state.title} retrieved at: {this.state.retrieved}</h6>
                {contents}

                <button className="btn btn-primary" type='button' onClick={this.refresh}>Refresh</button>
            </div>
        );
    }

    async populateWeatherData() {
        const token = await authService.getAccessToken();
        const response = await fetch('weatherforecast/44544', {
            headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
        });
        const data = await response.json();

        this.setState({ title: data.title, retrieved: data.retrievedAt, forecasts: data.consolidatedWeather.slice(1), loading: false });
    }
}
