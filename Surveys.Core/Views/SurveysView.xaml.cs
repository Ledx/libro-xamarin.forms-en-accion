﻿using Xamarin.Forms;

namespace Surveys.Core
{
    public partial class SurveysView : ContentPage
    {
        public SurveysView()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<SurveysViewModel>(this, Messages.NewSurvey, async (sender) =>
            {
                await Navigation.PushAsync(new SurveyDetailsView());
            });
        }
    }
}