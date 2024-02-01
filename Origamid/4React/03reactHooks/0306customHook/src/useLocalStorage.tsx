import React from 'react'

const useLocalStorage = (key: string, init: unknown) => {
  const [state, setState] = React.useState<string>(() => {
    const local = window.localStorage.getItem(key)
    return local ? local : String(init)
  })

  React.useEffect(() => {
    window.localStorage.setItem(key, state)
  }, [state, key])

  return [state, setState]
}

export default useLocalStorage;