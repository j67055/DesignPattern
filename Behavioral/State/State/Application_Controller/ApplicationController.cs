namespace State
{
    class ApplicationController
    {
        private ApplicationAlamState state;

        public ApplicationController(ApplicationAlamState state)
            => this.state = state;

        public void releaseNewUpdate()
            => state.releaseNewUpdate(this);
        public void update()
            => state.update(this);
        public void setStatus(ApplicationAlamState state)
            => this.state = state;
    }
}
